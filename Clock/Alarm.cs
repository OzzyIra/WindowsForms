using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clock
{
    public class Alarm
    {
        public static readonly string[] WeekDayNames = new string[7]{"Пн","Вт","Ср","Чт","Пт","Сб","Вс"};
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool[] WeekDays { get; private set; }
        public string Filename { get; set; }

        public Alarm()
        {
            WeekDays = new bool[7];
        }
        string WeekDaysToString()
        {
            string days = "";
            for(int i = 0;i<WeekDays.Length;i++)
            {
                if (WeekDays[i]) days += WeekDayNames[i];
                Console.Write(WeekDays[i] + "\t");
            }
            return days;
        }
        public override string ToString()
        {
            string result = "";
            if (Date != null && Date != DateTime.MinValue) result += $"{Date},";
            result += $"{Time.TimeOfDay},{WeekDaysToString()},{Filename.Split('\\').Last()}";
            return result;
        }
    }
}
