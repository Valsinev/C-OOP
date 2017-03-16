using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Weapon : ISupplement
    {
        private string unit;

        public Weapon(string unit)
        {
            this.unit = unit;
        }
        public int AggressionEffect { get; protected set; }

        public int HealthEffect { get; protected set; }

        public int PowerEffect { get; protected set; }

        public void ReactTo(ISupplement otherSupplement)
        {
            if (otherSupplement.GetType().Name == "WeaponrySkill")
            {
                this.AggressionEffect += 3;
                this.PowerEffect += 10;
            }
        }
    }
}
