using ClosedXML.Excel;
using Microsoft.Web.XmlTransform;
using Microsoft.Xrm.Sdk;
using Mockit.Common.Helpers;
using Mockit.Models;
using Mockit.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using XrmToolBox.Extensibility;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Controls
{
    public class DataGridControl : BaseControl
    {
        
        // private readonly DataGridView _dataGridView;
        private readonly System.Windows.Controls.DataGrid _fieldDataGrid;
        private readonly System.Windows.Controls.TextBox _searchBox;
        private readonly System.Windows.Controls.CheckBox _selectCheckBox;
        private readonly System.Windows.Controls.Button _mockSelectedFields;
        private readonly System.Windows.Controls.Button _exportMockProfileButton;
        public static ObservableCollection<GridRow> GridRows { get; set; } = new ObservableCollection<GridRow>();
        private ICollectionView _collectionView;
        public ICommand RowCommand { get;}

        public DataGridControl(ElementHost elementHost)
        {

            DataGridControlWPF _dataGridControlWPF = new DataGridControlWPF();
            elementHost.Child = _dataGridControlWPF;

            _fieldDataGrid = _dataGridControlWPF.fieldDataGrid;
            _searchBox = _dataGridControlWPF.SearchBox;
            _mockSelectedFields = _dataGridControlWPF.MockFields;
            _exportMockProfileButton = _dataGridControlWPF.ExportMockProfile;
            _selectCheckBox = _fieldDataGrid.Columns[0].Header as System.Windows.Controls.CheckBox;
            _selectCheckBox.Click += SelectAllCheckBox_Click;

            RowCommand = new RelayCommand<GridRow>(OnMockFieldAction);
            _dataGridControlWPF.DataContext = this;

            _collectionView = CollectionViewSource.GetDefaultView(GridRows);
            _fieldDataGrid.ItemsSource = _collectionView;
            _fieldDataGrid.SelectionChanged += OnSelectGridRow;
            _fieldDataGrid.Sorting += DataGrid_Sorting;
            
            _searchBox.TextChanged += OnSearchGridText;
            _mockSelectedFields.Click += MockSelectedFields;
            _exportMockProfileButton.Click += ExportMockProfile;
        }

        private void SelectAllCheckBox_Click(object sender, RoutedEventArgs e)
        {
            if (sender is System.Windows.Controls.CheckBox headerCheckBox)
            {
                bool isChecked = headerCheckBox.IsChecked == true;

                if (_collectionView != null)
                {
                    foreach (object item in _collectionView)
                    {
                        GridRow row = item as GridRow;
                        if (row != null)
                        {
                            row.IsChecked = isChecked;
                        }
                    }
                }
            }
        }

        private void MockSelectedFields(object sender, EventArgs e)
        {
            foreach(GridRow gridRow in GridRows.Where(r => r.IsChecked))
            {
                Mock suggestedMock = Helpers.GetSuggestedMockForField(gridRow.Field);
                gridRow.Mock = suggestedMock;
            }
        }

        private void ExportMockProfile(object sender, EventArgs e)
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Profile");
                List<MockProfile> mockProfiles = new List<MockProfile>();
                foreach (GridRow row in GridRows)
                {
                    MockProfile profile = new MockProfile
                    {
                        LogicalName = row.Field.LogicalName,
                        DisplayName = row.Field.DisplayName,
                        DataType = row.Field.DataType,
                        MockType = row.Mock?.MockType.ToString() ?? MockType.NONE.ToString(),
                        Expression = row.Mock?.Expression ?? string.Empty
                    };

                    mockProfiles.Add(profile);
                }

                worksheet.Cell("A1").InsertTable(mockProfiles);
                worksheet.Columns().AdjustToContents();

                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                    saveFileDialog.Title = "Save Mock Profile";
                    saveFileDialog.FileName = $"{_EntityDropdownControl.GetSelectedEntity()}_{DateTime.Now:yyyyMMddHHmm}.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            string filePath = saveFileDialog.FileName;
                            workbook.SaveAs(filePath);
                        }
                        catch (Exception ex)
                        {
                            System.Windows.MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        }
                    }
                }
            }
        }
        public ObservableCollection<GridRow> GetData()
        {
            return GridRows;
        }

        public void AddRow(CRMField field)
        {
            GridRow newRow = new GridRow
            {
                Field = field,
                Mock = new Mock()
            };

            GridRows.Add(newRow);
        }

        public void RemoveRow(CRMField field)
        {
            var row = GridRows.FirstOrDefault(r => r.Field?.LogicalName == field.LogicalName);
            if (row != null)
            {
                GridRows.Remove(row);
            }
        }

        public bool ContainsField(CRMField field)
        {
            return GridRows.Any(row => row.Field?.LogicalName == field.LogicalName);
        }

        public void Clear()
        {
            GridRows.Clear();
        }

        public void OnSelectGridRow(object sender, EventArgs e)
        {
            if (_fieldDataGrid.SelectedItem is GridRow selectedRow)
            {
                _FieldDetailsControl.ShowDetails(selectedRow.Field);
                _MockDetailsControl.ShowDetails(selectedRow);
            }
        }

        public void OnSearchGridText(object sender, EventArgs e)
        {
            string searchText = _searchBox.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(searchText))
            {
                _collectionView.Filter = null;
            }
            else
            {
                _collectionView.Filter = obj =>
                {
                    if (obj is GridRow row)
                    {
                        return row.Field?.DisplayName?.ToLower().Contains(searchText) == true ||
                               row.Field?.LogicalName?.ToLower().Contains(searchText) == true ||
                               row.Field?.DataType?.ToLower().Contains(searchText) == true ||
                               row.Mock?.MockType.ToString()?.ToLower().Contains(searchText) == true;
                    }
                    return false;
                };
            }

            _collectionView.Refresh();
        }

        private void DataGrid_Sorting(object sender, DataGridSortingEventArgs e)
        {
            e.Handled = true; // prevent default behavior

            _collectionView.SortDescriptions.Clear();

            ListSortDirection? newDirection = null;
            if (!e.Column.SortDirection.HasValue)
                newDirection = ListSortDirection.Ascending;
            else if (e.Column.SortDirection == ListSortDirection.Ascending)
                newDirection = ListSortDirection.Descending;
            else
                newDirection = null;

            if (newDirection != null)
            {
                e.Column.SortDirection = newDirection;
                _collectionView.SortDescriptions.Add(new SortDescription(e.Column.SortMemberPath, newDirection.Value));
            }
            else
            {
                e.Column.SortDirection = null;
            }
        }

        private void OnMockFieldAction(GridRow row)
        {
            Mock suggestedMock = Helpers.GetSuggestedMockForField(row.Field);
            row.Mock = suggestedMock;
            _MockDetailsControl.ShowDetails(row);
        }

        public void UpdateMockForField(CRMField field, Mock mock)
        {
            GridRow row = GridRows.FirstOrDefault(r => r.Field?.LogicalName == field.LogicalName);
            if (row != null)
            {
                row.Mock = mock;
            }
        }

    }
}