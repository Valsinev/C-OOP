using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class PowerCatalyst : Catalyst ,ISupplement
    {
        private const int PowerEffectChange = 3;

        public PowerCatalyst(string unit)
            :base(unit)
        {
            this.PowerEffect = PowerEffectChange;
        }
    }
}
