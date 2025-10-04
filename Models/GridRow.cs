using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mockit.Models
{
    public class GridRow : INotifyPropertyChanged
    {
        // private Mock _mock;

        public CRMField Field { get; set; }
        // public Mock Mock { get; set; }

        private Mock _mock;
        private bool _isChecked;
        //public Mock Mock
        //{
        //    get => _mock;
        //    set
        //    {
        //        if (_mock != value)
        //        {
        //            if (_mock != null)
        //                _mock.PropertyChanged -= Mock_PropertyChanged;

        //            _mock = value;

        //            if (_mock != null)
        //                _mock.PropertyChanged += Mock_PropertyChanged;

        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //private void Mock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    // Notify WPF that this nested property changed
        //    OnPropertyChanged($"Mock.{e.PropertyName}");
        //}

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
        //public string FieldName => Field?.DisplayName;
        //public string FieldLogicalName => Field?.LogicalName;
        //public string FieldType => Field?.DataType;
        //public string MockType => Mock?.MockType.ToString();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

    }
}