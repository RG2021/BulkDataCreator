using Mockit.Models;
using Mockit.Services;
using Mockit.Views;
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

namespace Mockit.Forms
{
    public partial class LookupViewForm : Form
    {
        public LookupViewForm(LookupViewControl lookupViewControl)
        {
            InitializeComponent();
            elementHost1.Child = lookupViewControl;
        }
    }
}
