using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clock
{
    public class Alarm:IComparable
    {
        public static readonly string[] WeekDayNames = new string[7]{"Пн","Вт","Ср","Чт","Пт","Сб","Вс"};
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
        public bool[] WeekDays { get; private set; }
        //string filename;
        //public string Filename
        //{
        //    set => filename = value;
        //    get => File.Exists(filename) ? filename :Path.GetFullPath(DEFAULT_LARM_FILE);
        //}
        //static readonly string DEFAULT_LARM_FILE = "..\\Sound\\LuciferMark_Pellegrino_-_Good_morning_Vietnam_63409154";
        public string Filename { get; set; } = "";

        public Alarm()
        {
            WeekDays = new bool[7];
        }
        public Alarm(string alarm_string)
        {
            string[] values = alarm_string.Split(',');
            Date = new DateTime(Convert.ToInt64(values[0]));
            Time = new DateTime(Convert.ToInt64(values[1]));
            WeekDays = WeekDaysFromString(values[2]);
            Filename = values[3];

        }
        bool[] WeekDaysFromString(string week_string)
        {
            bool[] weekdays = new bool[7];
            if (week_string.Contains("Пн")) weekdays[0] = true;
            if (week_string.Contains("Вт")) weekdays[1] = true;
            if (week_string.Contains("Ср")) weekdays[2] = true;
            if (week_string.Contains("Чт")) weekdays[3] = true;
            if (week_string.Contains("Пт")) weekdays[4] = true;
            if (week_string.Contains("Сб")) weekdays[5] = true;
            if (week_string.Contains("Вс")) weekdays[6] = true;
            return weekdays;
        }
        string WeekDaysToString()
        {
            string days = "";
            for(int i = 0;i<WeekDays.Length;i++)
            {
                if (WeekDays[i]) days += WeekDayNames[i];
                //Console.Write(WeekDays[i] + "\t");
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
        public string ToFileString()
        {
            string result = "";
            result += $"{Date.Ticks},";
            result += $"{Time.Ticks},";
            result += $"{WeekDaysToString()},";
            result += $"{Filename}";
            return result;
        }
        public int CompareTo(object other)
        {
            return this.Time.TimeOfDay.CompareTo((other as Alarm).Time.TimeOfDay);
        }
    }
}
