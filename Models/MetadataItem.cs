using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockit.Models
{
    [TypeConverter(typeof(ExpandableObjectConverter))]
    public class MetadataItem
    {
        [DisplayName("Name")]
        [Description("The name of the metadata item")]
        public string Name { get; set; }

        [DisplayName("Value")]
        [Description("The value of the metadata item")]
        public string Value { get; set; }

        public override string ToString() => Name;
    }
}
