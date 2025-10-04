using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mockit.Models
{
    public class GridRow : INotifyPropertyChanged
    {
        public CRMField Field { get; set; }

        private Mock _mock;
        private bool _isChecked;
        public Mock Mock
        {
            get => _mock;
            set { _mock = value; OnPropertyChanged(); }
        }

        public bool IsChecked 
        { 
            get => _isChecked;
            set { _isChecked = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}