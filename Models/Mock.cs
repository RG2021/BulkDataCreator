using Mockit.Common.ExpressionEngine;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Models
{
    public class Mock
    {

        public bool UseCustom { get; set; } = false; 
        public string Expression { get; set; } = string.Empty; 
        public string Value { get; set; } = string.Empty; 
        public MockType MockType { get; set; } = MockType.NONE;

        //private bool _useCustom;
        //public bool UseCustom
        //{
        //    get => _useCustom;
        //    set
        //    {
        //        if (_useCustom != value)
        //        {
        //            _useCustom = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //private string _expression = string.Empty;
        //public string Expression
        //{
        //    get => _expression;
        //    set
        //    {
        //        if (_expression != value)
        //        {
        //            _expression = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //private string _value = string.Empty;
        //public string Value
        //{
        //    get => _value;
        //    set
        //    {
        //        if (_value != value)
        //        {
        //            _value = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //private MockType _mockType = MockType.NONE;
        //public MockType MockType
        //{
        //    get => _mockType;
        //    set
        //    {
        //        if (_mockType != value)
        //        {
        //            _mockType = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}

        //public event PropertyChangedEventHandler PropertyChanged;
        //protected void OnPropertyChanged([CallerMemberName] string propertyName = null) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }
}