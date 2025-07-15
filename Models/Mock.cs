using static Mockit.Common.Enums.Enums;

namespace Mockit.Models
{
    public class Mock
    {
        public bool IsDynamic { get; set; }
        public string Expression { get; set; }
        public string Value { get; set; }
        public MockType MockType { get; set; }
    }
}