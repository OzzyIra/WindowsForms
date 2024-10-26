using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    class Alarm
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool[] WeekDays { get; private set; }
        public string Filename { get; set; }

        public override string ToString()
        {
            string result = "";
            if (Date != null) result += $"{Date},";
            result += $"{Time},{WeekDays},{Filename}";
            return result;
        }
    }
}
