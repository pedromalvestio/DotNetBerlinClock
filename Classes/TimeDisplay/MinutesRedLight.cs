using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeDisplay
{
    class MinutesRedLight : RedLight
    {
        public override bool LightValidation(int light)
        {
            return light % 3 == 0 && light != 0;
        }
    }
}
