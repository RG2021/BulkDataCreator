using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using static Mockit.Common.Enums.Constants;

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

        public void OnSelectField(object sender, EventArgs e)
        {
            foreach (ListViewItem listViewItem in _fieldsListView.Items)
            {
                string logicalName = listViewItem.Tag?.ToString();
                CRMField field = Fields.FirstOrDefault(fld => fld.LogicalName == logicalName);

                if (listViewItem.Checked && !_DataGridControl.ContainsField(field))
                {
                    _DataGridControl.AddRow(field);
                }

                else if (!listViewItem.Checked && _DataGridControl.ContainsField(field))
                {
                    _DataGridControl.RemoveRow(field);
                }
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
    }
}
