using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public class EntityDropDownControl : BaseControl
    {
        public static List<CRMEntity> Entities { get; set; }
        private readonly ComboBox _comboBox;

        public EntityDropDownControl(ComboBox comboBox)
        {
            _comboBox = comboBox;
        }

        public void LoadEntities()
        {
            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading entities...",
                Work = (worker, args) =>
                {
                    List<CRMEntity> entities = MetadataService.GetEntities();
                    args.Result = entities;
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Error loading entities: {args.Error.Message}");
                        return;
                    }

                    Entities = args.Result as List<CRMEntity>;
                    BindEntityDropdown();
                }
            });
        }

        private void BindEntityDropdown()
        {
            _comboBox.Items.Clear();

            foreach (CRMEntity entity in Entities)
            {
                _comboBox.Items.Add(new DropDownItem
                {
                    Text = $"{entity.DisplayName} ({entity.LogicalName})",
                    Value = entity.LogicalName
                });
            }

            if (_comboBox.Items.Count > 0)
            {
                _comboBox.SelectedIndex = 0;
            }

            _FieldDropdownControl.Clear();
        }

        public void OnSelectDropDown(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;

            if (comboBox.SelectedItem is DropDownItem selectedItem)
            {
                string logicalName = selectedItem.Value;
                CRMEntity selectedEntity = Entities.FirstOrDefault(ent => ent.LogicalName == logicalName);

                _FieldDropdownControl.LoadFields(selectedEntity);

                _DataGridControl.Clear();
            }
        }

        public string GetSelectedEntity()
        {
            DropDownItem selectedItem = (DropDownItem)_comboBox.SelectedItem;
            return selectedItem.Value.ToString();
        }

        public CRMEntity GetEntityObject(string entityLogicalName)
        {
        CRMEntity entity = Entities.FirstOrDefault(ent => ent.LogicalName == entityLogicalName);
        return entity;
        }

        public void Clear()
        {
            _comboBox.Items.Clear();
            _comboBox.SelectedIndex = -1;
            Entities = new List<CRMEntity>();
        }
    }
}