using System;
using System.Collections.Generic;
using System.Text;

namespace SalesHourTranslate.Model
{
    public class HourOfOperationData
    {
        public HourOfOperation Monday { get; set; }
        public HourOfOperation Tuesday { get; set; }
        public HourOfOperation Wednesday { get; set; }
        public HourOfOperation Thursday { get; set; }
        public HourOfOperation Friday { get; set; }
        public HourOfOperation Saturday { get; set; }
        public HourOfOperation Sunday { get; set; }
    }
}
