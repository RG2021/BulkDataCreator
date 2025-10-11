using DocumentFormat.OpenXml.Wordprocessing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Models
{
    internal class MockProfile
    {
        public string DisplayName { get; set; }
        public string LogicalName { get; set; }
        public string DataType { get; set; }
        public string MockType { get; set; }
        public string Expression { get; set; }
    }
}
