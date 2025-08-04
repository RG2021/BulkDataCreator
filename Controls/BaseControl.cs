using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Mockit.Services;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public partial class BaseControl : PluginControlBase
    {
        private Settings mySettings;
        private bool isConnected = false;
        protected static PluginControlBase ParentControlBase { get; private set; }
        protected static MetadataService MetadataService { get; private set; }
        protected static DataGenService DataGenService { get; private set; }
        protected static EntityDropDownControl _EntityDropdownControl { get; private set; }
        protected static FieldDropDownControl _FieldDropdownControl { get; private set; }
        protected static RecordCountControl _RecordCountControl { get; private set; }
        protected static DataGridControl _DataGridControl { get; private set; }
        protected static FieldDetailsControl _FieldDetailsControl { get; private set; }
        protected static MockDetailsControl _MockDetailsControl { get; private set; }
        protected static DataPreviewControl _DataPreviewControl { get; private set; }
        protected static DataGenerateControl _DataGenerateControl { get; private set; }

        public BaseControl()
        {
            InitializeComponent();
        }

        private void MyPluginControl_Load(object sender, EventArgs e)
        {
            if (!SettingsManager.Instance.TryLoad(GetType(), out mySettings))
            {
                mySettings = new Settings();
                LogWarning("Settings not found => a new settings file has been created!");
            }
            else
            {
                LogInfo("Settings found and loaded");
            }

            ParentControlBase = this;

            InitializeServices(Service);
            InitializeControls();
            RefereshTool();
        }


        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            if (mySettings != null && detail != null)
            {
                mySettings.LastUsedOrganizationWebappUrl = detail.WebApplicationUrl;
                LogInfo("Connection has changed to: {0}", detail.WebApplicationUrl);
            }

            InitializeServices(newService);
            RefereshTool();
        }

        private void InitializeServices(IOrganizationService service)
        {
            if (service == null)
            {
                isConnected = false;
                LogError("Service is null. Cannot initialize services.");
                return;
            }

            MetadataService = new MetadataService(service);
            DataGenService = new DataGenService(service);
            isConnected = true;

            LogInfo("Services initialized successfully.");
        }

        private void InitializeControls()
        {
            _EntityDropdownControl = new EntityDropDownControl(cmbEntities);
            _FieldDropdownControl = new FieldDropDownControl(selectFieldButton, fieldsListView);
            _RecordCountControl = new RecordCountControl(nudRecordCount);
            _FieldDetailsControl = new FieldDetailsControl(fieldDetailsGrid);
            _MockDetailsControl = new MockDetailsControl(mockDetailsPanel);
            _DataGridControl = new DataGridControl(gridColumns);
            _DataPreviewControl = new DataPreviewControl(actionGridPanel, previewBtn);
            _DataGenerateControl = new DataGenerateControl(generateBtn);

            LogInfo("Controls initialized successfully.");
        }

        private void RefereshTool()
        {
            if (isConnected)
            {
                LogInfo("Tool initialized successfully.");
                SetToolEnabled(true);
                _EntityDropdownControl?.LoadEntities();
            }
            else
            {
                LogWarning("Tool is not connected. Please connect to a CRM instance.");
                SetToolEnabled(false);
                _EntityDropdownControl?.Clear();
                _FieldDropdownControl?.Clear();
                _DataGridControl?.Clear();
            }
        }

        private void SetToolEnabled(bool isEnabled)
        {
            previewBtn.Enabled = isEnabled;
            generateBtn.Enabled = isEnabled;
        }

        private void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EntityDropdownControl.OnSelectDropDown(sender, e);
        }

        private void gridColumns_SelectionChanged(object sender, EventArgs e)
        {
            _DataGridControl.OnSelectGridRow(sender, e);
        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RG2021/Mockit/issues/new");
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/RG2021/Mockit/discussions/1");
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.linkedin.com/in/rg2021/");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}