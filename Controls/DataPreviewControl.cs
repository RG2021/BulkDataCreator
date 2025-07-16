using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            List<PreviewRecord> previewRecords = GetPreviewRecords(10);
            DataTable previewTable = ConvertPreviewToDataTable(previewRecords);
            _previewCRMDataGrid.DataSource = previewTable;
        }

        public List<PreviewRecord> GetPreviewRecords(int recordCount)
        {
            List<GridRow> gridRows = _DataGridControl.GetData().ToList();
            List<PreviewRecord> previewList = new List<PreviewRecord>();

            for (int i = 0; i < recordCount; i++)
            {
                PreviewRecord preview = new PreviewRecord();

                foreach (GridRow gridRow in gridRows)
                {
                    string logicalName = gridRow.Field.LogicalName;
                    string value = gridRow.Mock.Value;
                    preview.Fields[logicalName] = value;
                }

                previewList.Add(preview);
            }

            return previewList;
        }

        public DataTable ConvertPreviewToDataTable(List<PreviewRecord> records)
        {
            DataTable table = new DataTable();

            if (records == null || records.Count == 0)
                return table;

            foreach (string columnName in records[0].Fields.Keys)
            {
                table.Columns.Add(columnName);
            }

            foreach (PreviewRecord record in records)
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