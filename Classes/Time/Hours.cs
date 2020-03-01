using BerlinClock.Classes.TimeDisplay;
using BerlinClock.Classes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Time
{
    class Hours : IBerlinTime
    {
        List<ILightDisplay> lightDisplay = new List<ILightDisplay>()
            {
                new RedLight(),
                new OffLight()
            };

        public string ReturnBerlinPointer(string time)
        {
            
            return TopHours(time) + "\r\n" + BottomHours(time);
        }

        private string TopHours(string time)
        {
            int topHours = time.TimeToHour() / 5;

            var topHourPointer = new StringBuilder(4);

            for (int i = 1; i <= 4; i++)
                topHourPointer.Append(lightDisplay.FirstOrDefault(l => l.LightValidation(i <= topHours ? 1 : 0)).LightDisplay());

            return topHourPointer.ToString();
        }

        private string BottomHours(string time)
        {
            int bottomHour = time.TimeToHour() % 5;

            var bottomHourPointer = new StringBuilder(4);
            
            for (int i = 1; i <= 4; i++)
                bottomHourPointer.Append(lightDisplay.FirstOrDefault(l => l.LightValidation(i <= bottomHour ? 1 : 0)).LightDisplay());

            return bottomHourPointer.ToString();
        }
    }
}
