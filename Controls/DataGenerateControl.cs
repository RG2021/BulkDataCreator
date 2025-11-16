using ClosedXML.Excel;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Mockit.Common.Helpers;
using Mockit.Forms;
using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using MessageBox = System.Windows.Forms.MessageBox;

namespace Mockit.Controls
{
    public class DataGenerateControl : BaseControl
    {
        private readonly ToolStripButton _generateBtn;
        public DataGenerateControl(ToolStripButton generateBtn)
        {
            _generateBtn = generateBtn;
            _generateBtn.Click += GenerateData;
        }

        private void GenerateData(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            string entityLogicalName = _EntityDropdownControl.GetSelectedEntity();
            List<GridRow> gridRows = _DataGridControl.GetData().ToList();
            int totalRecordCount = _RecordCountControl.GetRecordCount();
            int batchSize = _SettingControl.GetSavedSetting().CreateBatchSize;
            
            List<ExecuteMultipleResponse> results = new List<ExecuteMultipleResponse>();

            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Creating records...",
                Work = (worker, args) =>
                {
                    try
                    {
                        int processed = 0;
                        while (processed < totalRecordCount)
                        {
                            if (worker.CancellationPending)
                            {
                                args.Cancel = true;
                                return;
                            }

                            int currentBatchSize = Math.Min(batchSize, totalRecordCount - processed);
                            ExecuteMultipleResponse response = CRMDataService.CreateRecords(entityLogicalName, gridRows, currentBatchSize);
                            results.Add(response);

                            if (response.IsFaulted)
                            {
                                return;
                            }

                            processed += currentBatchSize;

                            int percentage = (int)((double)processed / totalRecordCount * 100);
                            worker.ReportProgress(percentage, $"Created {processed} of {totalRecordCount} records.");

                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message, ex);
                    }

                },
                ProgressChanged = (args) => 
                {
                    ParentControlBase.SetWorkingMessage(args.UserState.ToString());
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    List<Guid> createdRecordIds = new List<Guid>();
                    List<string> allErrors = new List<string>();

                    int totalSuccess = 0;
                    int totalFailure = 0;

                    foreach (var response in results)
                    {
                        foreach (var item in response.Responses)
                        {
                            if (item.Fault != null)
                            {
                                totalFailure++;
                                string errorMsg = Helpers.BuildFaultMessage(item.Fault, item.RequestIndex);
                                allErrors.Add(errorMsg);
                            }
                            else
                            {
                                createdRecordIds.Add(((CreateResponse)item.Response).id);
                                totalSuccess++;
                            }
                        }
                    }

                    stopwatch.Stop();

                    string summary = $"Success: {totalSuccess}\nFailed: {totalFailure}\nTime taken: {Helpers.FormatElapsedTime(stopwatch)}";
                    if (allErrors.Count > 0)
                    {
                        summary += "\n\nDetails:\n" + string.Join("\n", allErrors);
                    }

                    using(StatusForm statusForm = new StatusForm(summary))
                    {
                        if(statusForm.ShowDialog() == DialogResult.Yes)
                        {
                            ExportData(entityLogicalName, createdRecordIds);
                        }
                    }
                },
                AsyncArgument = null,
                IsCancelable = true
            });
        }

        private void ExportData(string entityLogicalName, List<Guid> createdRecordIds)
        {
            int totalRecordCount = createdRecordIds.Count;
            int batchSize = _SettingControl.GetSavedSetting().ExportBatchSize;
            bool fetchedColumns = false;

            if (totalRecordCount == 0)
            {
                MessageBox.Show("No records to export.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Exporting data...",
                Work = (worker, args) =>
                {
                    try
                    {
                        DataTable exportResults = new DataTable();
                        int processedCount = 0;
                        for (int i = 0; i < totalRecordCount; i += batchSize)
                        {
                            int currentBatchSize = Math.Min(batchSize, totalRecordCount - i);
                            List<Guid> batchIds = createdRecordIds.GetRange(i, currentBatchSize);

                            EntityCollection exportResult = CRMDataService.GetRecordsFromID(entityLogicalName, batchIds);
                            if(fetchedColumns == false)
                            {
                                List<string> attributes = exportResult.Entities.SelectMany(e => e.Attributes.Keys).Distinct().ToList();
                                foreach (string attr in attributes)
                                {
                                    exportResults.Columns.Add(attr, typeof(string));
                                }
                                fetchedColumns = true;
                            }

                            foreach (Entity record in exportResult.Entities)
                            {
                                DataRow row = exportResults.NewRow();
                                foreach (var attr in record.Attributes)
                                {
                                    if(attr.Value is EntityReference entityRef)
                                    {
                                        row[attr.Key] = entityRef.Name;
                                    }
                                    else if(attr.Value is OptionSetValue optionSet)
                                    {
                                        row[attr.Key] = optionSet.Value.ToString();
                                    }
                                    else if(attr.Value is Money money)
                                    {
                                        row[attr.Key] = money.Value.ToString("F2");
                                    }
                                    else if (attr.Value is DateTime dateTime)
                                    {
                                        row[attr.Key] = dateTime.ToString("yyyy-MM-dd HH:mm:ss");
                                    }
                                    else
                                    {
                                        row[attr.Key] = attr.Value.ToString();
                                    }
                                }
                                exportResults.Rows.Add(row);
                            }
                            processedCount += currentBatchSize;
                            int percentage = (int)((double)processedCount / totalRecordCount * 100);
                            worker.ReportProgress(percentage, $"Exported {processedCount} of {totalRecordCount} records.");
                        }
                        args.Result = exportResults;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error: " + ex.Message, ex);
                    }
                },
                ProgressChanged = (args) =>
                {
                    ParentControlBase.SetWorkingMessage(args.UserState.ToString());
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!(args.Result is DataTable exportResults))
                    {
                        MessageBox.Show("Unknown error occurred.");
                        return;
                    }

                    using (XLWorkbook workbook = new XLWorkbook())
                    {
                        IXLWorksheet worksheet = workbook.Worksheets.Add("Data");
                        worksheet.Cell(1, 1).InsertTable(exportResults);
                        worksheet.Columns().AdjustToContents();

                        using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                        {
                            saveFileDialog.Filter = "Excel Files (*.xlsx)|*.xlsx";
                            saveFileDialog.Title = "Export records";
                            saveFileDialog.FileName = $"{entityLogicalName}_data_{DateTime.Now:yyyyMMddHHmm}.xlsx";

                            if (saveFileDialog.ShowDialog() == DialogResult.OK)
                            {
                                try
                                {
                                    string filePath = saveFileDialog.FileName;
                                    workbook.SaveAs(filePath);
                                }
                                catch (Exception ex)
                                {
                                    System.Windows.MessageBox.Show($"Error saving file: {ex.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                                }
                            }
                        }
                    }
                },
                AsyncArgument = null,
                IsCancelable = false
            });
        }
    }
}