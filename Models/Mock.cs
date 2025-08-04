using Mockit.Common.ExpressionEngine;
using static Mockit.Common.Constants.Constants;

namespace Mockit.Models
{
    public class Mock
    {
        public bool UseCustom { get; set; } = false;
        public string Expression { get; set; } = string.Empty;
        public string Value { get; set; } = string.Empty;
        public MockType MockType { get; set; } = MockType.NONE;
    }
}