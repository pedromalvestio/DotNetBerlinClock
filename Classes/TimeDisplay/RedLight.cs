using BerlinClock.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeDisplay
{
    class RedLight : ILightDisplay
    {
        public char LightDisplay()
        {
            return (char)LightEnum.Red;
        }

        public virtual bool LightValidation(int light)
        {
            return light != 0;
        }
    }
}
