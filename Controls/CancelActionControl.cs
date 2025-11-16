using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mockit.Controls
{
    public class CancelActionControl : BaseControl
    {
        private readonly ToolStripButton _cancelBtn;
        public CancelActionControl(ToolStripButton cancelBtn)
        {
            _cancelBtn = cancelBtn;
            _cancelBtn.Click += (object sender, EventArgs e) =>
            {
                try
                {
                    ParentControlBase.CancelWorker();
                }
                catch (Exception ex)
                {
                    return;
                }
            };
        }
    }
}
