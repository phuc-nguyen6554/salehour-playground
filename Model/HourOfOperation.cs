using System;
using System.Collections.Generic;
using System.Text;

namespace SalesHourTranslate.Model
{
    public class HourOfOperation
    {
        public DateTime? CloseTime { get; set; }
        public string Day { get; set; }
        public bool Checked { get; set; } = true;
        public DateTime? OpenTime { get; set; }
    }
}
