using static Mockit.Common.Enums.Enums;

namespace Mockit.Models
{
    public class Mock
    {
        public bool UseExpression { get; set; }
        public string Expression { get; set; }
        public string Value { get; set; }
        public MockType MockType { get; set; }

        public Mock() 
        { 
            UseExpression = false;
            Expression = null;
            Value = null;
            MockType = MockType.NONE;
        }
    }
}