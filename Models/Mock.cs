using Mockit.Common.ExpressionEngine;
using static Mockit.Common.Enums.Enums;

namespace Mockit.Models
{
    public class Mock
    {
        public bool UseCustom { get; set; }
        public string Expression { get; set; }
        public MockType MockType { get; set; }
        public string Value => ExpressionEngine.Evaluate(Expression);

        public Mock() 
        { 
            UseCustom = false;
            Expression = string.Empty;
            MockType = MockType.NONE;
        }
    }
}