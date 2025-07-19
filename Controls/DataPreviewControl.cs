using Mockit.Common.ExpressionEngine;
using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IdentityModel.Policy;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Windows.Documents;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Controls
{
    public class DataPreviewControl : BaseControl
    {

        private readonly DataGridView _previewCRMDataGrid;
        private readonly Button _previewButton;

        public static BindingList<GridRow> gridRows = new BindingList<GridRow>();

        public DataPreviewControl(Panel actionGridPanel)
        {

            _previewCRMDataGrid = actionGridPanel.Controls["crmDataGridView"] as DataGridView;
            _previewButton = actionGridPanel.Controls["previewBtn"] as Button;

            _previewButton.Click += OnPreview;
        }

        private void OnPreview(object sender, EventArgs e)
        {
            List<GridRow> gridRows = _DataGridControl.GetData().ToList();
            List<EvaluationRecord> previewRecords = Helpers.GetEvaluationRecords(gridRows, 15);

            DataTable previewTable = ConvertPreviewToDataTable(previewRecords);
            _previewCRMDataGrid.AutoGenerateColumns = true;
            _previewCRMDataGrid.DataSource = previewTable;

            foreach (DataGridViewColumn col in _previewCRMDataGrid.Columns)
            {
                col.HeaderText = previewTable.Columns[col.DataPropertyName].Caption;
            }
        }

        public DataTable ConvertPreviewToDataTable(List<EvaluationRecord> records)
        {
            DataTable table = new DataTable();

            if (records == null || records.Count == 0)
                return table;

            foreach (string fieldLogicalName in records[0].Fields.Keys)
            {
                string fieldDisplayName = _FieldDropdownControl.GetEntityFields().FirstOrDefault(f => f.LogicalName == fieldLogicalName)?.DisplayName ?? fieldLogicalName;

                DataColumn column = new DataColumn(fieldLogicalName)
                {
                    Caption = $"{fieldDisplayName} ({fieldLogicalName})"
                };

                table.Columns.Add(column);
            }

            foreach (EvaluationRecord record in records)
            {
                DataRow row = table.NewRow();

                foreach (KeyValuePair<string, string> field in record.Fields)
                {
                    row[field.Key] = field.Value ?? string.Empty;
                }

                table.Rows.Add(row);
            }

            return table;
        }

    }
}