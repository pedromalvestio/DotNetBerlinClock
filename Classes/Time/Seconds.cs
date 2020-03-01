using BerlinClock.Classes.TimeDisplay;
using BerlinClock.Classes.Utility;
using BerlinClock.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Time
{
    class Seconds : IBerlinTime
    {
        public string ReturnBerlinPointer(string time)
        {
            var secondsDisplay = new StringBuilder(1);

            secondsDisplay.Append((time.TimeToSeconds() % 2) == 0 ? (char) LightEnum.Yellow : (char) LightEnum.Off);

            return secondsDisplay.ToString();
        }
    }
}
