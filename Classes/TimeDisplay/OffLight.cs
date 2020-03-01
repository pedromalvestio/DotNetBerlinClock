﻿using BerlinClock.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeDisplay
{
    class OffLight : ILightDisplay
    {
        public char LightDisplay()
        {
            return (char) LightEnum.Off;
        }

        public bool LightValidation(int light)
        {
            return light == 0;
        }
    }
}
