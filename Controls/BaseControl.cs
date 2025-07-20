using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Mockit.Services;
using System;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public partial class BaseControl : PluginControlBase
    {
        private Settings mySettings;
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

            ParentControlBase = this;

            MetadataService = new MetadataService(Service);
            DataGenService = new DataGenService(Service);

            _EntityDropdownControl = new EntityDropDownControl(cmbEntities);
            _FieldDropdownControl = new FieldDropDownControl(selectFieldButton, fieldsListView);
            _RecordCountControl = new RecordCountControl(nudRecordCount);
            _FieldDetailsControl = new FieldDetailsControl(columnDetailsPanel);
            _MockDetailsControl = new MockDetailsControl(mockDetailsPanel);
            _DataGridControl = new DataGridControl(gridColumns);
            _DataPreviewControl = new DataPreviewControl(actionGridPanel);
            _DataGenerateControl = new DataGenerateControl(generateBtn);

            //ExecuteMethod(_EntityDropdownControl.LoadEntities);
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

        private void cmbEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            _EntityDropdownControl.OnSelectDropDown(sender, e);
        }

        //private void cmbColumns_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    _FieldDropdownControl.OnSelectDropDown(sender, e);
        //}

        private void gridColumns_SelectionChanged(object sender, EventArgs e)
        {
            _DataGridControl.OnSelectGridRow(sender, e);
        }

        private void metadataPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void fieldsListView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void columnDetailsPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelSelectEntity_Click(object sender, EventArgs e)
        {

        }
    }
}