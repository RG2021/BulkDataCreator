using Mockit.Common.ExpressionEngine;
using Mockit.Models;
using System;
using System.Windows.Forms;
using static Mockit.Common.Enums.Constants;

namespace Mockit.Controls
{
    public class RecordCountControl : BaseControl
    {

        private NumericUpDown _recordCount;

        public RecordCountControl(NumericUpDown recordCount)
        {
            _recordCount = recordCount;
        }

        public int GetRecordCount()
        {
            return (int)_recordCount.Value;
        }
    }
}