using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public class DataGridControl : BaseControl
    {
        
        private readonly DataGridView _dataGridView;
        public static BindingList<GridRow> gridRows = new BindingList<GridRow>();

        public DataGridControl(DataGridView dataGridView)
        {
            _dataGridView = dataGridView;
            InitializeGrid();
        }

        private void InitializeGrid()
        {
            _dataGridView.AutoGenerateColumns = false;
            _dataGridView.DataSource = gridRows;
        }

        public void AddRow(GridRow row)
        {
            gridRows.Add(row);
        }

        public void RemoveRow(CRMField field)
        {
            var row = gridRows.FirstOrDefault(r => r.Field?.LogicalName == field.LogicalName);
            if (row != null)
            {
                gridRows.Remove(row);
            }
        }

        public bool ContainsField(CRMField field)
        {
            return gridRows.Any(row => row.Field?.LogicalName == field.LogicalName);
        }

        public void Clear()
        {
            gridRows.Clear();
        }

        public void OnSelectGridRow(object sender, EventArgs e)
        {
            if (_dataGridView.CurrentRow?.DataBoundItem is GridRow selectedRow)
            {
                _FieldDetailsControl.ShowDetails(selectedRow.Field);
            }
        }
    }
}