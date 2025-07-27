using Microsoft.Xrm.Sdk.Messages;
using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

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
            int batchSize = 200;
            int totalSuccess = 0;
            int totalFailure = 0;
            List<string> allErrors = new List<string>();

            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Creating records...",
                Work = (worker, args) =>
                {
                    try
                    {
                        int processed = 0;
                        List<ExecuteMultipleResponse> batchResponses = new List<ExecuteMultipleResponse>();
                        while (processed < totalRecordCount)
                        {
                            int currentBatchSize = Math.Min(batchSize, totalRecordCount - processed);
                            var response = DataGenService.CreateData(entityLogicalName, gridRows, currentBatchSize);
                            batchResponses.Add(response);
                            processed += currentBatchSize;

                            int percentage = (int)((double)processed / totalRecordCount * 100);
                            worker.ReportProgress(percentage, $"Created {processed} of {totalRecordCount} records.");

                        }
                        args.Result = batchResponses;
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error during record creation: " + ex.Message, ex);
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
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    var batchResponses = args.Result as List<ExecuteMultipleResponse>;
                    if (batchResponses == null)
                    {
                        MessageBox.Show("Unknown error occurred.");
                        return;
                    }

                    foreach (var response in batchResponses)
                    {
                        foreach (var item in response.Responses)
                        {
                            if (item.Fault != null)
                            {
                                totalFailure++;
                                string errorMsg = $"Index {item.RequestIndex}: {item.Fault.Message}";
                                allErrors.Add(errorMsg);
                            }
                            else
                            {
                                totalSuccess++;
                            }
                        }
                    }

                    stopwatch.Stop();

                    string summary = $"Success: {totalSuccess}\nFailed: {totalFailure}\nTime taken: {stopwatch.Elapsed.TotalSeconds} sec";

                    if (allErrors.Count > 0)
                    {
                        summary += "\n\nDetails:\n" + string.Join("\n", allErrors);
                    }

                    MessageBox.Show(summary, "Record Creation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }
    }
}