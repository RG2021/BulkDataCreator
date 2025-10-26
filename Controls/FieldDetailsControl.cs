using Mockit.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using System.Xml.XPath;
using XrmToolBox.Extensibility;
using Mockit.Common.Helpers;

namespace Mockit.Controls
{
    
    public class FieldDetailsControl : BaseControl
    {
        private readonly PropertyGrid _propertyGrid;

        public FieldDetailsControl(PropertyGrid fieldPropertyGrid)
        {
            _propertyGrid = fieldPropertyGrid;
        }

        public void ShowDetails(CRMField field)
        {
            _propertyGrid.SelectedObject = field.GetPropertyDescriptor();
            _propertyGrid.ExpandAllGridItems();
            _propertyGrid.HorizontalScroll.Visible = true;
        }
    }
}