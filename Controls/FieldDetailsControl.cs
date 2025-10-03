using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.XPath;
using XrmToolBox.Extensibility;
using static Mockit.Common.Helpers.Properties;

namespace Mockit.Controls
{
    
    public class FieldDetailsControl : BaseControl
    {
        private readonly DataGridView _fieldDetailsGrid;
        private readonly PropertyGrid _propertyGrid;

        public FieldDetailsControl(PropertyGrid fieldPropertyGrid)
        {
            _propertyGrid = fieldPropertyGrid;

            //_fieldDetailsGrid = fieldDetailsPanel;

            //_fieldDetailsGrid.Rows.Add("Display Name", "-");
            //_fieldDetailsGrid.Rows.Add("Logical Name", "-");
            //_fieldDetailsGrid.Rows.Add("Data Type", "-");

            //AdjustRowHeightsToFillGrid(_fieldDetailsGrid);
        }

        public void ShowDetails(CRMField field)
        {
            ICustomTypeDescriptor dynamicProps = CRMFieldPropertyHelper.CreatePropertyDescriptor(field);
            _propertyGrid.SelectedObject = dynamicProps;
            _propertyGrid.ExpandAllGridItems();
            _propertyGrid.HorizontalScroll.Visible = true;
            

            //_fieldDetailsGrid.Rows.Clear();

            //_fieldDetailsGrid.Rows.Add("Display Name", field.DisplayName);
            //_fieldDetailsGrid.Rows.Add("Logical Name", field.LogicalName);
            //_fieldDetailsGrid.Rows.Add("Data Type", field.DataType);

            //if (field.Metadata != null)
            //{
            //    foreach (var item in field.Metadata)
            //    {
            //        _fieldDetailsGrid.Rows.Add(item.Name, item.Value);
            //    }
            //}

            //AdjustRowHeightsToFillGrid(_fieldDetailsGrid);
        }

        private void AdjustRowHeightsToFillGrid(DataGridView grid)
        {
            int rowCount = grid.Rows.Count;
            if (rowCount <= 0) return;

            int totalHeight = grid.ClientSize.Height;

            int rowHeight = totalHeight / rowCount;

            foreach (DataGridViewRow row in grid.Rows)
            {
                row.Height = rowHeight;
            }
        }
    }
}