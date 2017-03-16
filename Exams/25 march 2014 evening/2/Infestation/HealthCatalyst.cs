using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class HealthCatalyst : Catalyst,ISupplement
    {
        private const int HealthEffectChange = 3;

        public HealthCatalyst(string unit)
            :base(unit)
        {
            this.HealthEffect = HealthEffectChange;
        }
    }
}
