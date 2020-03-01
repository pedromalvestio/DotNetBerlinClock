using BerlinClock.Classes.Time;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BerlinClock.Classes
{
    class BerlinClockDisplay : IBerlinClock
    {
        List<IBerlinTime> berlimTime = new List<IBerlinTime>()
            {
                new Seconds(),
                new Hours(),
                new Minutes()
            };

        public string ShowClock(string time)
        {
            return string.Join(Environment.NewLine, berlimTime.Select(b => b.ReturnBerlinPointer(time)));
        }
    }
}
