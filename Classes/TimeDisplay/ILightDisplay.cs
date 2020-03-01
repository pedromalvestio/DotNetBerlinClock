using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BerlinClock.Classes.TimeDisplay
{
    public interface ILightDisplay
    {
        bool LightValidation(int light);

        char LightDisplay();
    }
}
