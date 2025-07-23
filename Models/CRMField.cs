using System.Collections.Generic;
using System.Windows.Documents;

namespace Mockit.Models
{
    public class CRMField
    {
        public string LogicalName { get; set; }
        public string DisplayName { get; set; }
        public string DataType { get; set; }
        public bool IsCustom { get; set; }
        public CRMEntity Entity { get; set; }
        public List<MetadataItem> Metadata { get; set; }
    }
}