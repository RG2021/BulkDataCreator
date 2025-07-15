using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Mockit.Helpers;
using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using static Mockit.Common.Enums.Enums;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Mockit.Controls
{
    public partial class BaseControl : PluginControlBase
    {
        private Settings mySettings;
        protected static MetadataService MetadataService { get; private set; }
        protected static EntityDropDownControl _EntityDropdownControl { get; private set; }
        protected static FieldDropDownControl _FieldDropdownControl { get; private set; }
        protected static DataGridControl _DataGridControl { get; private set; }
        protected static FieldDetailsControl _FieldDetailsControl { get; private set; }

        public BaseControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            //ShowInfoNotification("This is a notification that can lead to XrmToolBox repository", new Uri("https://github.com/MscrmTools/XrmToolBox"));

            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();
                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            MetadataService = new MetadataService(Service);

            _EntityDropdownControl = new EntityDropDownControl(cmbEntities);
            _FieldDropdownControl = new FieldDropDownControl(cmbColumns);
            _DataGridControl = new DataGridControl(gridColumns);
            _FieldDetailsControl = new FieldDetailsControl(tableLayoutPanel2);

            _EntityDropdownControl.LoadEntities();
        }

        

        private void tsbClose_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbSample_Click(object sender, EventArgs e)
        {
            ExecuteMethod(GetAccounts);
        }

        private void GetAccounts()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Getting accounts",
                Work = (worker, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new QueryExpression("account")
                    {
                        TopCount = 50
                    });
                },
                PostWorkCallBack = (args) =>
                {
                    if (args.Error != null)
                    {
                        MessageBox.Show(args.Error.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    var result = args.Result as EntityCollection;
                    if (result != null)
                    {
                        MessageBox.Show($"Found {result.Entities.Count} accounts");
                    }
                }
            });
        }

        private void MyPluginControl_OnCloseTool(object sender, EventArgs e)
        {
            // Before leaving, save the settings
            SettingsManager.Instance.Save(GetType(), mySettings);
        }

        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }
        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridColumns_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EntityDropdownControl.OnSelectDropDown(sender, e);
        }

        private void cmbColumns_SelectedIndexChanged(object sender, EventArgs e)
        {
            _FieldDropdownControl.OnSelectDropDown(sender, e);
        }

        private void gridColumns_SelectionChanged(object sender, EventArgs e)
        {
            _DataGridControl.OnSelectGridRow(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}