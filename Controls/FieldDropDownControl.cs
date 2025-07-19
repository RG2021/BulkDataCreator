using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Controls
{
    public class FieldDropDownControl : BaseControl
    {
        private static List<CRMField> Fields { get; set; }
        private readonly ListView _fieldsListView;
        private readonly Button _selectFieldButton;

        public FieldDropDownControl(Button selectFieldButton, ListView fieldsListView)
        {
            //_comboBox = comboBox;

            _selectFieldButton = selectFieldButton;
            _fieldsListView = fieldsListView;
            _fieldsListView.Columns.Add("Fields", _fieldsListView.Width - 25);
            _fieldsListView.HeaderStyle = ColumnHeaderStyle.None;

            //_fieldsListView.Columns.Add("Text", 150);
            //_fieldsListView.Columns.Add("Logical Name", 150);

            _selectFieldButton.Click += OnSelectFieldButtonClick;
            _fieldsListView.ItemChecked += OnSelectField;
            _fieldsListView.LostFocus += OnFostLocus;
        }

        //private void ListViewFields_DoubleClick(object sender, EventArgs e)
        //{
        //    if (listViewFields.SelectedItems.Count > 0)
        //    {
        //        var selected = listViewFields.SelectedItems[0];
        //        var field = new CRMField
        //        {
        //            DisplayName = selected.Text,
        //            LogicalName = selected.SubItems[1].Text
        //        };

        //        FieldSelected?.Invoke(field);
        //        listViewFields.Visible = false;
        //    }
        //}

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
                }
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

            //if (_comboBox.Items.Count > 0)
            //{
            //    _comboBox.SelectedIndex = 0;
            //}
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

            //ComboBox comboBox = sender as ComboBox;

            //if (comboBox.SelectedItem is DropDownItem selectedItem)
            //{
            //    string logicalName = selectedItem.Value;
            //    CRMField selectedField = Fields.FirstOrDefault(fld => fld.LogicalName == logicalName);

            //    if (_DataGridControl.ContainsField(selectedField))
            //    {
            //        _DataGridControl.RemoveRow(selectedField);
            //    }

            //    else
            //    {
            //        _DataGridControl.AddRow(selectedField);
            //    }
            //}
        }

        public List<CRMField> GetEntityFields()
        {
            return Fields;
        }
    }
}
