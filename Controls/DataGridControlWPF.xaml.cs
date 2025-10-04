using Mockit.Common.Helpers;
using Mockit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Mockit.Controls
{
    public partial class DataGridControlWPF : UserControl
    {
        
        public DataGridControlWPF()
        {
            InitializeComponent();
        }

        //private void MockButton_Click(object sender, RoutedEventArgs e)
        //{
        //    if (sender is Button btn && btn.DataContext is GridRow gridRow)
        //    {
        //        CRMField field = gridRow.Field;
        //        Mock suggestedMock = Helpers.GetSuggestedMockForField(field);
        //        gridRow.Mock = suggestedMock;

        //        // _MockDetailsControl.ShowDetails(gridRow.Mock);

        //        // If using ObservableCollection + INotifyPropertyChanged, this is usually not needed:
        //        // myDataGrid.Items.Refresh(); // only if Mock property doesn't implement INotifyPropertyChanged
        //    }
        //}
    }
}
