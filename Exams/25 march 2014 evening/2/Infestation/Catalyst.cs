using System;

namespace Infestation
{
    public abstract class Catalyst : ISupplement
    {
        private int aggressionEffect;
        private int healthEffect;
        private int powerEffect;
        private string unit;

        public Catalyst(string unit)
        {
            this.AggressionEffect = aggressionEffect;
            this.HealthEffect = healthEffect;
            this.PowerEffect = powerEffect;
            this.Unit = unit;
        }

        public int AggressionEffect
        {
            get
            {
                return this.aggressionEffect;
            }
            protected set
            {
                this.aggressionEffect = value;
            }
        }

        public int HealthEffect
        {
            get
            {
                return this.healthEffect;
            }
            protected set
            {
                this.healthEffect = value;
            }
        }

        public int PowerEffect
        {
            get
            {
                return this.powerEffect;
            }
            protected set
            {
                this.powerEffect = value;
            }
        }

        public string Unit
        {
            get
            {
                return this.unit;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Unit cannot be null!");
                }
                this.unit = value;
            }
        }

        public void ReactTo(ISupplement otherSupplement)
        {
            throw new NotImplementedException();
        }
    }
}