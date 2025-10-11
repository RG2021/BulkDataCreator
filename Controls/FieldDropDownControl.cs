using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using ClosedXML.Excel;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Controls
{
    public class FieldDropDownControl : BaseControl
    {
        private static List<CRMField> Fields { get; set; }
        private readonly ListView _fieldsListView;
        private readonly Button _selectFieldButton;
        private readonly Button _importMockProfileButton;

        public FieldDropDownControl(Button selectFieldButton, ListView fieldsListView, Button importMockProfileButton)
        {
            _selectFieldButton = selectFieldButton;
            _fieldsListView = fieldsListView;
            _importMockProfileButton = importMockProfileButton;
            _fieldsListView.Columns.Add("Fields", _fieldsListView.Width - 25);
            _fieldsListView.HeaderStyle = ColumnHeaderStyle.None;
            _fieldsListView.Resize += (s, e) =>
            {
                foreach (ColumnHeader column in _fieldsListView.Columns)
                {
                    column.Width = _fieldsListView.ClientSize.Width - 25;
                }
            };

            _selectFieldButton.Click += OnSelectFieldButtonClick;
            _importMockProfileButton.Click += OnImportMockProfileButtonClick;
            _fieldsListView.LostFocus += OnFostLocus;
            _fieldsListView.Visible = false;

        }

        public void LoadFields(CRMEntity entity)
        {
            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading fields...",
                Work = (worker, args) =>
                {
                    List<CRMField> fields = MetadataService.GetFieldsForEntity(entity);
                    args.Result = fields;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Error loading fields: {args.Error.Message}");
                        return;
                    }

                    Fields = args.Result as List<CRMField>;
                    BindFieldDropdown();
                },

            });
        }

        private void BindFieldDropdown()
        {
            _fieldsListView.ItemChecked -= OnSelectField;

            _fieldsListView.Items.Clear();

            _fieldsListView.Items.Add(new ListViewItem
            {
                Text = "Select All",
                Tag = "Mock_SelectAllFields",
            });

            foreach (CRMField field in Fields)
            {
                _fieldsListView.Items.Add(new ListViewItem
                {
                    Text = $"{field.DisplayName} ({field.LogicalName})",
                    Tag = field.LogicalName,
                });
            }

            _fieldsListView.ItemChecked += OnSelectField;
        }

        private void OnSelectFieldButtonClick(object sender, EventArgs e)
        {
            _fieldsListView.ItemChecked -= OnSelectField;
            _fieldsListView.Visible = !_fieldsListView.Visible;
            _fieldsListView.ItemChecked += OnSelectField;
        }

        private void OnImportMockProfileButtonClick(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                openFileDialog.Title = "Import Mock Profile";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    using(IXLWorkbook workbook = new XLWorkbook(filePath))
                    {
                        try
                        {
                            IXLWorksheet worksheet = workbook.Worksheet("Profile");
                            List<MockProfile> mockProfiles = worksheet.RowsUsed().Skip(1).Select(row => new MockProfile
                            {
                                LogicalName = row.Cell(2).GetString(),
                                MockType = row.Cell(4).GetString(),
                                Expression = row.Cell(5).GetString()
                            }).ToList();

                            //_fieldsListView.ItemChecked -= OnSelectField;

                            foreach (MockProfile profile in mockProfiles)
                            {
                                ListViewItem fieldItem = _fieldsListView.Items.Cast<ListViewItem>().FirstOrDefault(item => item.Tag?.ToString() == profile.LogicalName);
                                if (fieldItem != null)
                                {
                                    fieldItem.Checked = true;
                                    CRMField field = GetField(profile.LogicalName);
                                    if (field != null)
                                    {
                                        Mock mock = new Mock
                                        {
                                            MockType = Enum.TryParse(profile.MockType, out MockType mockType) ? mockType : MockType.NONE,
                                            UseCustom = mockType == MockType.CUSTOM,
                                            Expression = mockType == MockType.NONE ? string.Empty : profile.Expression
                                        };

                                        _DataGridControl.UpdateMockForField(field, mock);
                                    }
                                }
                            }
                        }
                        catch(Exception ex)
                        {
                            MessageBox.Show($"Error reading profile template: {ex.Message}", "Invalid profile");
                            return;
                        }
                    }
                }
            }
        }

        private void OnFostLocus(object sender, EventArgs e)
        {
            _fieldsListView.Visible = false;
        }

        public void OnSelectField(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item == null) return;

            string logicalName = e.Item.Tag?.ToString();

            if(logicalName == "Mock_SelectAllFields")
            {
                bool checkState = e.Item.Checked;
                foreach (ListViewItem item in _fieldsListView.Items)
                {
                    if (item.Tag?.ToString() == "Mock_SelectAllFields") continue;
                    item.Checked = checkState;
                }
                return;
            }
            CRMField field = Fields.FirstOrDefault(fld => fld.LogicalName == logicalName);

            if (e.Item.Checked && !_DataGridControl.ContainsField(field))
            {
                _DataGridControl.AddRow(field);
            }

            else if (!e.Item.Checked && _DataGridControl.ContainsField(field))
            {
                _DataGridControl.RemoveRow(field);
            }

            int selectedCount = _fieldsListView.CheckedItems.Count;
            _selectFieldButton.Text = $"{selectedCount} fields selected";
        }

        public List<CRMField> GetEntityFields()
        {
            return Fields;
        }

        public CRMField GetField(string logicalName)
        {
            return Fields?.FirstOrDefault(f => f.LogicalName == logicalName);
        }

        public void Clear()
        {
            Fields?.Clear();
            _fieldsListView.Items.Clear();
            _selectFieldButton.Text = "Select Fields";
        }
    }
}
