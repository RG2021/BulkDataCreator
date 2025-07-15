using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.XPath;
using XrmToolBox.Extensibility;

namespace Mockit.Controls
{
    
    public class FieldDetailsControl : BaseControl
    {
        private readonly TableLayoutPanel _fieldDetailsPanel;

        public FieldDetailsControl(TableLayoutPanel fieldDetailsPanel)
        {
            _fieldDetailsPanel = fieldDetailsPanel;
        }

        public void ShowDetails(CRMField field)
        {
            Label lblDisplayName = _fieldDetailsPanel.Controls["lblDisplayName"] as Label;
            Label lblLogicalName = _fieldDetailsPanel.Controls["lblLogicalName"] as Label;
            Label lblDataType = _fieldDetailsPanel.Controls["lblDataType"] as Label;

            lblDisplayName.Text = field.DisplayName;
            lblLogicalName.Text = field.LogicalName;
            lblDataType.Text = field.DataType;
        }
    }
}