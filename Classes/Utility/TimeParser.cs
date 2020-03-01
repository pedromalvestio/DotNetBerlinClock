using BerlinClock.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Utility
{
    public static class TimeParser
    {
        public static int TimeToSeconds(this string time)
        {
            return int.Parse(time.Split(':')[(int)HourFormatEnum.Sec]);
        }

        public static int TimeToMinutes(this string time)
        {
            return int.Parse(time.Split(':')[(int)HourFormatEnum.Min]);
        }

        public static int TimeToHour(this string time)
        {
            return int.Parse(time.Split(':')[(int)HourFormatEnum.Hour]);
        }
    }
}
