using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Documents;

namespace Mockit.Models
{
    public class CRMField
    {
        [DisplayName("Display Name")]
        [Description("The display name of the field")]
        public string DisplayName { get; set; }

        [DisplayName("Logical Name")]
        [Description("The logical name of the field in CRM")]
        public string LogicalName { get; set; }

        [DisplayName("Data Type")]
        [Description("The data type of the field")]
        public string DataType { get; set; }

        [Browsable(false)]
        public bool IsCustom { get; set; }

        [Browsable(false)]
        public CRMEntity Entity { get; set; }

        [Browsable(true)]
        [Category("Metadata")]
        [DisplayName("Metadata Items")]
        public List<MetadataItem> Metadata { get; set; } = new List<MetadataItem>();

        public string GetMetadataValue(string name)
        {
            MetadataItem item = Metadata.FirstOrDefault(m => m.Name == name);
            return item?.Value;
        }

    }
}