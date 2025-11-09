using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XrmToolBox.Extensibility;

namespace Mockit.Models
{
    public class Setting
    {
        public int CreateBatchSize { get; set; }
        public int ExportBatchSize { get; set; }

        public Setting() 
        { 
            CreateBatchSize = 100;
            ExportBatchSize = 1000;
        }
    }
}
