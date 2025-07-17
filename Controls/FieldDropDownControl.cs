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
        public static List<CRMField> Fields { get; set; }
        private readonly ComboBox _comboBox;

        public FieldDropDownControl(ComboBox comboBox)
        {
            _comboBox = comboBox;
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
                }
            });
        }

        private void BindFieldDropdown()
        {
            _comboBox.Items.Clear();

            foreach (CRMField field in Fields)
            {
                _comboBox.Items.Add(new DropDownItem
                {
                    Text = $"{field.DisplayName} ({field.LogicalName})",
                    Value = field.LogicalName
                });
            }

            if (_comboBox.Items.Count > 0)
            {
                _comboBox.SelectedIndex = 0;
            }
        }

        public void OnSelectDropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.SelectedItem is DropDownItem selectedItem)
            {
                string logicalName = selectedItem.Value;
                CRMField selectedField = Fields.FirstOrDefault(fld => fld.LogicalName == logicalName);

                if (_DataGridControl.ContainsField(selectedField))
                {
                    _DataGridControl.RemoveRow(selectedField);
                }

                else
                {
                    _DataGridControl.AddRow(selectedField);
                }
            }
        }

        public List<CRMField> GetEntityFields()
        {
            return Fields;
        }
    }
}