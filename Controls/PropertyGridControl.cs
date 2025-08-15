using Mockit.Common.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace Mockit.Controls
{
    public class PropertyGridControl : BaseControl
    {
        private readonly TableLayoutPanel _tableLayoutPanel;
        private readonly DockPanel _dockPanel;
        private readonly DockContent _dockContent;
        private readonly PropertyGrid _propertyGrid;
        public PropertyGridControl(TableLayoutPanel tableLayoutPanel, DockPanel dockPanel)
        {
            _tableLayoutPanel = tableLayoutPanel;
            _dockPanel = dockPanel;
            _propertyGrid = new PropertyGrid
            {
                Dock = DockStyle.Fill,
            };

            _dockContent = new DockContent
            {
                Text = "Documentation",
            };

            InitializePropertyGrid();
        }

        private void InitializePropertyGrid()
        {
            string methods = Encoding.UTF8.GetString(Properties.Resources.mockit_tokens);
            var data = JsonSerializer.Deserialize<List<Documentation.CategoryDefinition>>(methods);
            var rootWrapper = new Documentation.RootWrapper(data);

            _propertyGrid.SelectedObject = rootWrapper;

            _dockContent.Controls.Add(_propertyGrid);
            _dockContent.Show(_dockPanel, DockState.DockRight);
            _dockContent.VisibleChanged += ToggleDocumentation;
        }
        public void ToggleDocumentation(object sender, EventArgs e)
        {
            if (_dockContent.Visible)
                HideDocumentation();
            else
                ShowDocumentation();
        }

        public void ShowDocumentation()
        {
            _dockContent.Show(_dockPanel, DockState.DockRight);
            _dockPanel.PerformLayout();
            _tableLayoutPanel.PerformLayout();
        }

        public void HideDocumentation()
        {
            // _dockContent.Hide();
            _dockPanel.PerformLayout();
            _tableLayoutPanel.PerformLayout();
        }
        
    }
}
