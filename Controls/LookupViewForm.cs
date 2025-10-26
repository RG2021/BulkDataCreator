using Mockit.Models;
using Mockit.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    public partial class LookupViewForm : Form
    {
        private readonly PluginControlBase _parentControlBase;
        private readonly MetadataService _metadataService;
        private readonly List<string> _lookupEntities;
        private List<CRMView> loadedViews;
        private readonly System.Windows.Controls.DataGrid _lookupRecordsGrid;
        private System.Windows.Controls.TextBox _searchTextBox;
        private System.Windows.Controls.Button _searchButton;
        private System.Windows.Controls.ComboBox _entityViewsBox;
        private System.Windows.Controls.ComboBox _lookupEntityBox;

        public LookupViewForm(LookupViewControl lookupViewControl)
        {
            InitializeComponent();
            //_parentControlBase = pluginControlBase;
            //_metadataService = metadataService;
            //_lookupEntities = lookupEntities;

            //LookupViewControl lookupViewControl = new LookupViewControl();
            elementHost1.Child = lookupViewControl;

            //_lookupRecordsGrid = lookupViewControl.LookupGrid;
            //_searchTextBox = lookupViewControl.SearchTextBox;
            //_searchButton = lookupViewControl.SearchButton;
            //_entityViewsBox = lookupViewControl.SelectedViewBox;
            //_lookupEntityBox = lookupViewControl.LookupEntityBox;

            //_lookupEntityBox.SelectionChanged += LoadLookupViews;
            //_entityViewsBox.SelectionChanged += LoadLookupRecords;
            //_searchButton.Click += LoadLookupRecords;

            //LoadLookupEntities(lookupEntities);
        }

        //private void LoadLookupEntities(List<string> lookupEntities)
        //{
        //    foreach (string entity in lookupEntities)
        //    {
        //        _lookupEntityBox.Items.Add(new DropDownItem
        //        {
        //            Text = entity,
        //            Value = entity
        //        });
        //    }
        //    if (_lookupEntityBox.Items.Count > 0)
        //    {
        //        _lookupEntityBox.SelectedIndex = 0;
        //    }
        //}
        //private void LoadLookupViews(object sender, EventArgs e)
        //{
        //    string selectedEntity = (_lookupEntityBox.SelectedItem as DropDownItem)?.Value.ToString();
        //    _parentControlBase.WorkAsync(new WorkAsyncInfo
        //    {
        //        Message = "Loading views...",
        //        Work = (worker, args) =>
        //        {
        //            List<CRMView> views = _metadataService.GetEntityViews(selectedEntity);
        //            args.Result = views;
        //        },
        //        PostWorkCallBack = (args) =>
        //        {
        //            if (args.Error != null)
        //            {
        //                MessageBox.Show($"Error loading views: {args.Error.Message}");
        //                return;
        //            }
        //            loadedViews = args.Result as List<CRMView>;
        //            _entityViewsBox.Items.Clear();

        //            foreach (CRMView view in loadedViews)
        //            {
        //                _entityViewsBox.Items.Add(new DropDownItem
        //                {
        //                    Text = view.Name,
        //                    Value = view.ID
        //                });
        //            }
        //            if (_entityViewsBox.Items.Count > 0)
        //            {
        //                _entityViewsBox.SelectedIndex = 0;
        //            }
        //        }
        //    });
        //}

        //private void LoadLookupRecords(object sender, EventArgs e)
        //{
        //    if (_entityViewsBox.SelectedItem is DropDownItem item)
        //    {
        //        CRMView selectedView = loadedViews.FirstOrDefault(v => v.ID == item.Value.ToString());
        //        string searchText = _searchTextBox.Text;
        //        _parentControlBase.WorkAsync(new WorkAsyncInfo
        //        {
        //            Message = "Loading lookup records...",
        //            Work = (worker, args) =>
        //            {
        //                DataTable records = _metadataService.GetRecordsForView(selectedView.FetchXML, searchText);
        //                args.Result = records;
        //            },
        //            PostWorkCallBack = (args) =>
        //            {
        //                if (args.Error != null)
        //                {
        //                    MessageBox.Show($"Error loading records: {args.Error.Message}");
        //                    return;
        //                }
        //                DataTable records = args.Result as DataTable;
        //                _lookupRecordsGrid.ItemsSource = records.DefaultView;
        //            }
        //        });
        //    }
        //}
    }
}
