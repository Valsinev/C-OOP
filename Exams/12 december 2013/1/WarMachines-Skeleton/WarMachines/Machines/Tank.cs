
namespace WarMachines.Machines
{
    using System;
    using WarMachines.Interfaces;

    public class Tank : Machine, IMachine, ITank
    {
        private const int InnitialHealthPoints = 100;
        private const double DefensePointsChange = 30;
        private const double AttackPointsChange = 40;

        private bool defenseMode;

        public Tank(string name, double attackPoints, double defensePoints) 
            : base(name, attackPoints, defensePoints, InnitialHealthPoints)
        {
            this.defenseMode = false;
            ToggleDefenseMode();
        }

        public bool DefenseMode
        {
            get
            {
                return this.defenseMode;
            }
        }

        public void ToggleDefenseMode()
        {
            this.defenseMode = !this.defenseMode;
            if (this.defenseMode)
            {
                this.AttackPoints -= AttackPointsChange;
                this.DefensePoints += DefensePointsChange;
            }
            else
            {
                this.AttackPoints += AttackPointsChange;
                this.DefensePoints -= DefensePointsChange;
            }
        }

        public override string ToString()
        {
            var newLine = Environment.NewLine;
            string defModeOnOrOff = this.defenseMode ? "ON" : "OFF";
            string defModeToString = string.Format(" *Defense: {0}", defModeOnOrOff);

            return base.ToString() + newLine + defModeToString;
        }
    }
}
