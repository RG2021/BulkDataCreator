using Microsoft.Xrm.Sdk.Messages;
using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public class DataGenerateControl : BaseControl
    {

        private readonly Button _generateBtn;

        public DataGenerateControl(Button generateBtn)
        {
            _generateBtn = generateBtn;
            _generateBtn.Click += GenerateData;
        }

        private void GenerateData(object sender, EventArgs e)
        {
            string entityLogicalName = _EntityDropdownControl.GetSelectedEntity();
            List<GridRow> gridRows = _DataGridControl.GetData().ToList();
            int recordCount = _RecordCountControl.GetRecordCount();

            ParentControlBase.WorkAsync(new WorkAsyncInfo
            {
                Message = "Creating records...",
                Work = (worker, args) =>
                {
                    args.Result = DataGenService.CreateData(entityLogicalName, gridRows, recordCount);
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    ExecuteMultipleResponse response = args.Result as ExecuteMultipleResponse;

                    if (response == null)
                    {
                        MessageBox.Show("Unknown error occurred.");
                        return;
                    }

                    int success = 0;
                    int failure = 0;
                    List<string> errors = new List<string>();

                    foreach (var item in response.Responses)
                    {
                        if (item.Fault != null)
                        {
                            failure++;
                            string errorMsg = $"Index {item.RequestIndex}: {item.Fault.Message}";
                            errors.Add(errorMsg);
                        }
                        else
                        {
                            success++;
                        }
                    }

                    string summary = $"Success: {success}\n Failed: {failure}";

                    if (errors.Count > 0)
                    {
                        summary += "\n\nDetails:\n" + string.Join("\n", errors);
                    }

                    MessageBox.Show(summary, "Record Creation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            });
        }
    }
}