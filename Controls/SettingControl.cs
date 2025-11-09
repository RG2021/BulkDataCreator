using DocumentFormat.OpenXml.Office.SpreadSheetML.Y2023.MsForms;
using Mockit.Forms;
using Mockit.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Forms;

namespace Mockit.Controls
{
    public class SettingControl : BaseControl
    {
        private static Setting settings;
        private static SettingForm _settingForm;

        private static NumericUpDown _createBatchSizeControl;
        private static NumericUpDown _exportBatchSizeControl;
        public SettingControl(ToolStripButton button)
        {
            _settingForm = new SettingForm();
            _createBatchSizeControl = _settingForm.Controls.Find("createBatchSizeCount", true).FirstOrDefault() as NumericUpDown;
            _exportBatchSizeControl = _settingForm.Controls.Find("exportBatchSizeCount", true).FirstOrDefault() as NumericUpDown;

            button.Click += LoadSettingForm;
            IntializeSettings();
        }

        private void IntializeSettings()
        {
            SettingsManager.Instance.TryLoad<Setting>(typeof(Setting), out settings);
            if (settings == null)
            {
                settings = new Setting();
            }
        }

        private void LoadSettingForm(object sender, EventArgs e)
        {
            LoadUserSettings();

            if (_settingForm.ShowDialog() == DialogResult.OK)
            {
                SaveUserSettings();
                SettingsManager.Instance.Save(typeof(Setting), settings);
            }
        }

        private void LoadUserSettings()
        {
            _createBatchSizeControl.Value = settings.CreateBatchSize;
            _exportBatchSizeControl.Value = settings.ExportBatchSize;
        }

        private void SaveUserSettings()
        {
            settings =  new Setting
            {
                CreateBatchSize = (int)_createBatchSizeControl.Value,
                ExportBatchSize = (int)_exportBatchSizeControl.Value,
            };
        }
        public Setting GetSavedSetting()
        {
            return settings;
        }

    }
}
