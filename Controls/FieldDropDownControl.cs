using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Controls
{
    public class FieldDropDownControl : BaseControl
    {
        private static List<CRMField> Fields { get; set; }
        private readonly ListView _fieldsListView;
        private readonly Button _selectFieldButton;

        public FieldDropDownControl(Button selectFieldButton, ListView fieldsListView)
        {
            _selectFieldButton = selectFieldButton;
            _fieldsListView = fieldsListView;
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
            _fieldsListView.ItemChecked += OnSelectField;
            _fieldsListView.LostFocus += OnFostLocus;
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
            _fieldsListView.Items.Clear();

            _fieldsListView.Items.Add(new ListViewItem
            {
                Text = "Select All",
                Tag = "Mock_SelectAllFields"
            });

            foreach (CRMField field in Fields)
            {
                _fieldsListView.Items.Add(new ListViewItem
                {
                    Text = $"{field.DisplayName} ({field.LogicalName})",
                    Tag = field.LogicalName
                });
            }
        }

        private void OnSelectFieldButtonClick(object sender, EventArgs e)
        {
            _fieldsListView.Visible = !_fieldsListView.Visible;
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
                    OnSelectField(sender, new ItemCheckedEventArgs(item));
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
