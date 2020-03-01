using BerlinClock.Classes.TimeDisplay;
using BerlinClock.Classes.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.Time
{
    class Minutes : IBerlinTime
    {
        public string ReturnBerlinPointer(string time)
        {
            return TopMinutes(time) + "\r\n" + BottomMinutes(time);
        }

        private string TopMinutes(string time)
        {
            List<ILightDisplay> lightDisplay = new List<ILightDisplay>()
            {
                new MinutesRedLight(),
                new MinutesYellowLight(),
                new OffLight()
            };

            int topMinutes = time.TimeToMinutes() / 5;

            var topMinutesBlock = new StringBuilder(11);

            for (int i = 1; i <= 11; i++)
                topMinutesBlock.Append(lightDisplay.FirstOrDefault(l => l.LightValidation(i <= topMinutes ? i : 0)).LightDisplay());

            return topMinutesBlock.ToString();
        }

        private string BottomMinutes(string time)
        {
            List<ILightDisplay> lightDisplay = new List<ILightDisplay>()
            {
                new YellowLight(),
                new OffLight()
            };

            int bottomMinutes = time.TimeToMinutes() % 5;

            var bottomMinutesPointer = new StringBuilder(4);

            for (int i = 1; i <= 4; i++)
                bottomMinutesPointer.Append(lightDisplay.FirstOrDefault(l => l.LightValidation(i <= bottomMinutes ? 1 : 0)).LightDisplay());

            return bottomMinutesPointer.ToString();
        }
    }
}
