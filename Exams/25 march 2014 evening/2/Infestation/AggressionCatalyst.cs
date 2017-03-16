using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class AggressionCatalyst : Catalyst, ISupplement
    {
        private const int AggressionEffectChange = 3;

        public AggressionCatalyst(string unit)
            :base(unit)
        {
            this.AggressionEffect = AggressionEffectChange;
        }
    }
}
