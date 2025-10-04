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
using static Mockit.Common.Constants.Constants;

namespace Mockit.Controls
{
    public class DataPreviewControl : BaseControl
    {

        private readonly DataGridView _previewCRMDataGrid;
        private readonly ToolStripButton _previewButton;
        private readonly Label _previewDataLabel;

        public static BindingList<GridRow> gridRows = new BindingList<GridRow>();

        public DataPreviewControl(Panel actionGridPanel, ToolStripButton previewBtn)
        {

            Panel buttonPanel = actionGridPanel.Controls["buttonPanel"] as Panel;
            _previewCRMDataGrid = actionGridPanel.Controls["crmDataGridView"] as DataGridView;
            _previewDataLabel = actionGridPanel.Controls["previewDataLabel"] as Label;

            _previewButton = previewBtn;
            _previewButton.Click += OnPreview;
        }

        private void OnPreview(object sender, EventArgs e)
        {
            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Generating preview...",
                Work = (worker, args) =>
                {
                    try
                    {
                        List<GridRow> gridRows = _DataGridControl.GetData().ToList();
                        List<EvaluationRecord> previewRecords = Helpers.GetEvaluationRecords(gridRows, 10);
                        DataTable previewTable = ConvertPreviewToDataTable(previewRecords);

                        args.Result = new { previewRecords, previewTable };
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message, ex);
                    }
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show($"Error generating preview: {args.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    dynamic result = args.Result;
                    List<EvaluationRecord> previewRecords = result.previewRecords as List<EvaluationRecord>;
                    DataTable previewTable = result.previewTable as DataTable;

                    _previewCRMDataGrid.AutoGenerateColumns = true;
                    _previewCRMDataGrid.DataSource = previewTable;

                    foreach (DataGridViewColumn col in _previewCRMDataGrid.Columns)
                    {
                        col.HeaderText = previewTable.Columns[col.DataPropertyName].Caption;
                    }

                    _previewDataLabel.Visible = previewRecords == null || previewRecords.Count == 0;
                },
                AsyncArgument = null,
                IsCancelable = true
            });
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