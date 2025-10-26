using DocumentFormat.OpenXml.Presentation;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Mockit.Common.Constants;
using Mockit.Common.Helpers;
using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Media;
using XrmToolBox.Extensibility;
using static Mockit.Common.Constants.Constants;
using Binding = System.Windows.Data.Binding;
using CheckBox = System.Windows.Controls.CheckBox;
using HorizontalAlignment = System.Windows.HorizontalAlignment;
using MessageBox = System.Windows.Forms.MessageBox;
using Style = System.Windows.Style;

namespace Mockit.Controls
{
    public class LookupSearchControl : BaseControl
    {
        private int nextPage = 0;
        private GridRow selectedRow;
        private bool _isLoading = false;
        private List<CRMView> loadedViews;

        private DataTable _lookupGridData;
        private readonly Dictionary<string, List<CRMField>> _entityFieldsCache = new Dictionary<string, List<CRMField>>();

        private System.Windows.Controls.DataGrid _lookupRecordsGrid;
        private System.Windows.Controls.TextBox _searchTextBox;
        private System.Windows.Controls.ComboBox _searchFieldsBox;
        private System.Windows.Controls.Button _searchButton;
        private System.Windows.Controls.ComboBox _entityViewsBox;
        private System.Windows.Controls.ComboBox _lookupEntityBox;
        private System.Windows.Controls.TextBox _expressionTextBox;
        
        public void LoadLookupSearch(GridRow row)
        {
            selectedRow = row;
            if (selectedRow == null)
            {
                MessageBox.Show("No field is selected for lookup search.", "Lookup Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!Helpers.IsLookupTypeField(selectedRow.Field))
            {
                MessageBox.Show("The selected field is not a lookup type.", "Lookup Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> lookupEntities = selectedRow.Field.GetMetadataValue("LookupEntities").Split(',').ToList();
            if (lookupEntities == null || lookupEntities.Count == 0)
            {
                MessageBox.Show("No lookup entities defined for the selected field.", "Lookup Search", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            LookupViewControl lookupViewControl = new LookupViewControl();
            using (LookupViewForm lookupForm = new LookupViewForm(lookupViewControl))
            {
                _lookupRecordsGrid = lookupViewControl.LookupGrid;
                _searchTextBox = lookupViewControl.SearchTextBox;
                _searchFieldsBox = lookupViewControl.SearchFieldsBox;
                _searchButton = lookupViewControl.SearchButton;
                _entityViewsBox = lookupViewControl.SelectedViewBox;
                _lookupEntityBox = lookupViewControl.LookupEntityBox;
                _expressionTextBox = lookupViewControl.ExpressionTextBox;

                nextPage = 1;

                _lookupEntityBox.SelectionChanged += OnEntitySelect;
                _entityViewsBox.SelectionChanged += LoadLookupRecords;
                _searchButton.Click += LoadLookupRecords;

                _lookupGridData = new DataTable();
                _lookupRecordsGrid.ItemsSource = _lookupGridData.DefaultView;
                _lookupRecordsGrid.Loaded += OnGridLoaded;

                LoadLookupEntities(lookupEntities);

                if (lookupForm.ShowDialog() == DialogResult.Yes)
                {
                    row.Mock = new Mock
                    {
                        MockType = MockType.LOOKUP,
                        UseCustom = false,
                        Expression = _expressionTextBox.Text
                    };
                    _MockDetailsControl.ShowDetails(row);
                }
            }
        }

        private void OnEntitySelect(object sender, EventArgs e)
        {
            LoadLookupViews();
            LoadLookupSearchableFields();

            //if (sender is System.Windows.Controls.ComboBox item)
            //{
            //    string fieldName = selectedRow.Field.LogicalName;
            //    string entityName = item.Text;
            //    ResetMockExpression();
            //}
        }

        private void OnGridLoaded(object sender, EventArgs e)
        {
            if (VisualTreeHelper.GetChild(_lookupRecordsGrid, 0) is Decorator border && border.Child is ScrollViewer scrollViewer)
            {
                scrollViewer.ScrollChanged += (s, a) =>
                {
                    if (_isLoading)
                        return;

                    if ((a.VerticalOffset + a.ViewportHeight >= a.ExtentHeight - 5) && a.VerticalChange > 0)
                    {
                        _isLoading = true;
                        LoadLookupRecords(sender, e);
                        _lookupRecordsGrid.Focus();
                        scrollViewer.ScrollToVerticalOffset(scrollViewer.VerticalOffset - 10);
                    }
                };
            }
        }

        private void LoadLookupEntities(List<string> lookupEntities)
        {
            _lookupEntityBox.Items.Clear();
            foreach (string entity in lookupEntities)
            {
                _lookupEntityBox.Items.Add(new DropDownItem
                {
                    Text = entity.Trim(),
                    Value = entity.Trim()
                });
            }
            if (_lookupEntityBox.Items.Count > 0)
            {
                _lookupEntityBox.SelectedIndex = 0;
            }
        }
        private void LoadLookupViews()
        {
            string selectedEntity = (_lookupEntityBox.SelectedItem as DropDownItem)?.Value.ToString();
            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading views...",
                Work = (worker, args) =>
                {
                    List<CRMView> views = MetadataService.GetEntityViews(selectedEntity);
                    args.Result = views;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Error loading views: {args.Error.Message}");
                        return;
                    }
                    loadedViews = args.Result as List<CRMView>;
                    _entityViewsBox.Items.Clear();

                    foreach (CRMView view in loadedViews)
                    {
                        _entityViewsBox.Items.Add(new DropDownItem
                        {
                            Text = view.Name,
                            Value = view.ID
                        });
                    }
                    if (_entityViewsBox.Items.Count > 0)
                    {
                        _entityViewsBox.SelectedIndex = 0;
                    }
                }
            });
        }
        private void LoadLookupSearchableFields()
        {
            string selectedEntityLogicalName = (_lookupEntityBox.SelectedItem as DropDownItem)?.Value.ToString();
            CRMEntity selectedEntity = _EntityDropdownControl.GetEntityObject(selectedEntityLogicalName) ?? new CRMEntity 
            { 
                LogicalName = selectedEntityLogicalName,
            };

            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading Search fields...",
                Work = (worker, args) =>
                {
                    List<CRMField> fields = _entityFieldsCache.ContainsKey(selectedEntityLogicalName) ? _entityFieldsCache[selectedEntityLogicalName] : MetadataService.GetEntityFields(selectedEntity, isSearchable: true);
                    _entityFieldsCache[selectedEntityLogicalName] = fields;
                    args.Result = fields.Where(f => (f.DataType == "StringType" || f.DataType == "MemoType")).ToList();
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Error loading fields: {args.Error.Message}");
                        return;
                    }

                    List<CRMField> searchableFields = args.Result as List<CRMField>;
                    _searchFieldsBox.Items.Clear();
                    foreach (CRMField field in searchableFields)
                    {
                        _searchFieldsBox.Items.Add(new DropDownItem
                        {
                            Text = $"{field.DisplayName} ({field.LogicalName})",
                            Value = field.LogicalName
                        });
                    }
                    if (_searchFieldsBox.Items.Count > 0)
                    {
                        _searchFieldsBox.SelectedIndex = 0;
                    }
                },
            });
        }
        private void LoadLookupRecords(object sender, EventArgs e)
        {
            if (sender is FrameworkElement element && element.Tag is string tag && (tag == "SelectViewAction" || tag == "SearchAction"))
            {
                _lookupGridData.Clear();
                ResetMockExpression();
                nextPage = 1;
            }

            if (_entityViewsBox.SelectedItem is DropDownItem item && nextPage > 0)
            {
                string selectedEntity = (_lookupEntityBox.SelectedItem as DropDownItem)?.Value.ToString();
                string searchField = (_searchFieldsBox.SelectedItem as DropDownItem)?.Value.ToString();
                string searchText = _searchTextBox.Text;
                CRMView selectedView = loadedViews.FirstOrDefault(v => v.ID == item.Value.ToString());

                ParentControlBase.WorkAsync(new WorkAsyncInfo
                {
                    Message = "Loading lookup records...",
                    Work = (worker, args) =>
                    {
                        (EntityCollection records, bool moreRecords) = CRMDataService.RetriveRecordsFromView(selectedView.FetchXML, nextPage, searchField, searchText);
                        DataTable dataTable = Helpers.ConvertEntityCollectionToDataTable(records, useSelected: true);
                        bool isFirstLoad = nextPage == 1;
                        nextPage = moreRecords ? nextPage + 1 : 0;

                        args.Result = (dataTable, isFirstLoad);
                    },
                    PostWorkCallBack = (args) =>
                    {
                        if (args.Error != null)
                        {
                            System.Windows.MessageBox.Show($"Error loading records: {args.Error.Message}");
                            return;
                        }

                        _isLoading = false;

                        var (records, isFirstLoad) = ((DataTable, bool))args.Result;

                        if (isFirstLoad)
                        {
                            _lookupGridData = records.Clone();
                            _lookupRecordsGrid.ItemsSource = _lookupGridData.DefaultView;

                            foreach (var col in _lookupRecordsGrid.Columns)
                            {
                                if (col.SortMemberPath == "IsSelected" && col is DataGridCheckBoxColumn checkBoxColumn)
                                {
                                    Style style = new Style(typeof(CheckBox));
                                    style.Setters.Add(new Setter(CheckBox.HorizontalAlignmentProperty, HorizontalAlignment.Center));
                                    style.Setters.Add(new Setter(CheckBox.VerticalAlignmentProperty, VerticalAlignment.Center));
                                    style.Setters.Add(new EventSetter(CheckBox.CheckedEvent, new RoutedEventHandler(OnCheckBoxChanged)));
                                    style.Setters.Add(new EventSetter(CheckBox.UncheckedEvent, new RoutedEventHandler(OnCheckBoxChanged)));

                                    checkBoxColumn.ElementStyle = style;
                                    checkBoxColumn.EditingElementStyle = style;

                                    checkBoxColumn.Binding = new Binding("IsSelected") { Mode = BindingMode.TwoWay };
                                    checkBoxColumn.IsReadOnly = false;
                                    checkBoxColumn.Header = "Select";
                                }
                                else if (col is DataGridTextColumn textColumn)
                                {
                                    Style style = new Style(typeof(TextBlock));
                                    style.Setters.Add(new Setter(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center));
                                    style.Setters.Add(new Setter(TextBlock.PaddingProperty, new Thickness(5, 0, 5, 0)));
                                    textColumn.ElementStyle = style;

                                    col.IsReadOnly = true;
                                    col.Header = $"{_entityFieldsCache[selectedEntity].FirstOrDefault(f => f.LogicalName == col.SortMemberPath)?.DisplayName ?? col.SortMemberPath} ({col.SortMemberPath})";
                                }
                            }
                        }

                        foreach (DataRow record in records.Rows)
                        {
                            _lookupGridData.ImportRow(record);
                        }
                    }
                });
            }
        }
        private void ResetMockExpression()
        {
            string fieldName = selectedRow.Field.LogicalName.ToString();
            string entityName = _lookupEntityBox.Text;

            string defaultExpression = Helpers.GetExpression(Constants.MockType.LOOKUP);
            string expression = defaultExpression.Replace("fieldName", fieldName).Replace("entityName", entityName).Replace("GUID1, GUID2, etc", "");
            _expressionTextBox.Text = expression;
        }
        private void OnCheckBoxChanged(object sender, RoutedEventArgs e)
        {
            if (sender is CheckBox chk && chk.DataContext is DataRowView row)
            {
                bool isChecked = chk.IsChecked == true;
                row["IsSelected"] = isChecked;

                string selectedEntity = _lookupEntityBox.Text;
                string selectedID = row[$"{selectedEntity}id"]?.ToString()?.ToLower();
                if (string.IsNullOrEmpty(selectedID)) return;

                string expression = _expressionTextBox.Text;
                string pattern = @"\(([^()]*)\)(?!.*\()";
                Match match = Regex.Match(expression, pattern);
                if (!match.Success) return;

                string inside = match.Groups[1].Value.Trim();
                List<string> guids = inside.Split(',').Select(x => x.Trim()).Where(x => !string.IsNullOrEmpty(x)).ToList();

                if (isChecked && !guids.Contains(selectedID))
                    guids.Add(selectedID);
                else
                    guids.Remove(selectedID);

                string newInside = string.Join(", ", guids);
                string updatedExpression = Regex.Replace(expression, pattern, $"({newInside})");

                _expressionTextBox.Text = updatedExpression;
            }
        }
    }
}
