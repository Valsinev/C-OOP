
namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;

    class Fighter : Machine, IMachine, IFighter
    {
        private const int InnitialHealthPoints = 200;

        private bool stealthMode;

        public Fighter(string name, double attackPoints, double defensePoints, bool stealthMode)
            : base(name, attackPoints, defensePoints, InnitialHealthPoints)
        {
            this.stealthMode = stealthMode;
        }

        public bool StealthMode
        {
            get
            {
                return this.stealthMode;
            }
        }

        public void ToggleStealthMode()
        {
            this.stealthMode = !this.stealthMode;
        }

        public override string ToString()
        {
            var newLine = Environment.NewLine;
            string stealthModeOnOrOff = this.stealthMode ? "ON" : "OFF";
            string stealthfModeToString = string.Format(" *Stealth: {0}", stealthModeOnOrOff);

            return base.ToString() + newLine + stealthfModeToString;
        }
    }
}
