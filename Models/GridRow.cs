using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Mockit.Models
{
    public class GridRow : INotifyPropertyChanged
    {
        private Mock _mock;

        public CRMField Field { get; set; }
        // public Mock Mock {  get; set; }
        
        public Mock Mock
        {
            get => _mock;
            set { _mock = value; OnPropertyChanged(); }
        }

        public string FieldName => Field?.DisplayName;
        public string FieldLogicalName => Field?.LogicalName;
        public string FieldType => Field?.DataType;
        public string MockType => Mock?.MockType.ToString();

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}