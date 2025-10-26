using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Mockit.Common.Helpers;

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

        public ICustomTypeDescriptor GetPropertyDescriptor()
        {
            List<DynamicProperty> props = new List<DynamicProperty>
            {
                new DynamicProperty("Display Name", DisplayName, "General"),
                new DynamicProperty("Logical Name", LogicalName, "General"),
                new DynamicProperty("Data Type", DataType, "General"),
            };

            if (Metadata != null && Metadata.Any())
            {
                foreach (MetadataItem m in Metadata)
                {
                    props.Add(new DynamicProperty(m.Name, m.Value, "Metadata"));
                }
            }

            return new DynamicTypeDescriptor(props);
        }

    }
}