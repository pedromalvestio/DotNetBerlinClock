using BerlinClock.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BerlinClock
{
    public class TimeConverter : ITimeConverter
    {
        BerlinClockDisplay berlinClock = new BerlinClockDisplay();
        public string convertTime(string aTime)
        {
            return berlinClock.ShowClock(aTime);
        }
    }
}
