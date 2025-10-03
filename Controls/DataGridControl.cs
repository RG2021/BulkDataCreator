using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using System.Windows.Input;
using XrmToolBox.Extensibility;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Controls
{
    public class DataGridViewModel
    {
        public ObservableCollection<GridRow> GridRows { get; set; } = new ObservableCollection<GridRow>();

        public ICommand RowCommand { get; set; }
    }

    public class DataGridControl : BaseControl
    {
        
        // private readonly DataGridView _dataGridView;
        private readonly DataGridControlWPF _dataGridControlWPF;
        private readonly System.Windows.Controls.DataGrid _fieldDataGrid;
        public static ObservableCollection<GridRow> GridRows { get; set; } = new ObservableCollection<GridRow>();
        public ICommand RowCommand { get;}

        public DataGridControl(ElementHost elementHost)
        {
            // _dataGridView = dataGridView;

            _dataGridControlWPF = new DataGridControlWPF();
            _fieldDataGrid = _dataGridControlWPF.fieldDataGrid;
            elementHost.Child = _dataGridControlWPF;

            RowCommand = new RelayCommand<GridRow>(OnMockFieldAction);

            _dataGridControlWPF.DataContext = this;
            _fieldDataGrid.ItemsSource = GridRows;
            _fieldDataGrid.SelectionChanged += OnSelectGridRow;

            

            // InitializeGrid();
        }

        //private void InitializeGrid()
        //{

        //    _fieldDataGrid.ItemsSource = GridRows;
           

            


        //    //_dataGridView.AutoGenerateColumns = false;
        //    //_dataGridView.DataSource = gridRows;
        //    //_dataGridView.CellContentClick += OnMockFieldAction;
        //    //_MockDetailsControl.MockChanged += (s, e) =>
        //    //{
        //    //    _fieldDataGrid.Refresh
        //    //};
        //}

        
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
        private void OnMockFieldAction(GridRow row)
        {

            CRMField field = row.Field;
            Mock suggestedMock = Helpers.GetSuggestedMockForField(field);
            row.Mock = suggestedMock;

            _MockDetailsControl.ShowDetails(row);

            //if (e.RowIndex < 0 || e.ColumnIndex < 0)
            //    return;

            //var column = _dataGridView.Columns[e.ColumnIndex];

            //if (column is DataGridViewButtonColumn && column.Name == "Action")
            //{
            //    DataGridViewRow row = _dataGridView.Rows[e.RowIndex];
            //    string boundValue = row.Cells["FieldLogicalName"].Value?.ToString();
            //    CRMField field = _FieldDropdownControl.GetField(boundValue);

            //    Mock suggestedMock = Helpers.GetSuggestedMockForField(field);

            //    GridRow gridRow = row.DataBoundItem as GridRow;
            //    if (gridRow != null)
            //    {
            //        gridRow.Mock = suggestedMock;
            //        _MockDetailsControl.ShowDetails(gridRow.Mock);
            //        _dataGridView.Refresh();
            //    }
            //}
        }

    }
}