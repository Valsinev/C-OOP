
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using WarMachines.Interfaces;

    public abstract class Machine : IMachine
    {
        private string name;
        private IPilot pilot;
        private IList<string> targets;

        public Machine(string name, double attackPoints, double defensePoints,double healthPoints)
        {
            this.Name = name;
            this.AttackPoints = attackPoints;
            this.DefensePoints = defensePoints;
            this.targets = new List<string>();
            this.HealthPoints = healthPoints;
        }

        public double AttackPoints { get; protected set; }

        public double DefensePoints { get; protected set; }

        public double HealthPoints { get; set; }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                Validator.NullOrEmptyString(value, "Machine name cannot be null or empty!");
                this.name = value;
            }
        }


        public IPilot Pilot
        {
            get
            {
                return this.pilot;
            }
            set
            {
                Validator.NullObject(value, "Pilot cannot be null!");
                this.pilot = value;
            }
        }

        public IList<string> Targets
        {
            get
            {
                return new List<string>(targets);
            }
        }

        public void Attack(string target)
        {
            Validator.NullOrEmptyString(target, "Target cannot be null or empty!");
            this.targets.Add(target);
        }

        public override string ToString()
        {
            var output = new StringBuilder();
            string targetsOrNone = this.targets.Count == 0 ? "None" : string.Join(", ", this.targets);

            output.AppendLine(string.Format("- {0}", this.Name));
            output.AppendLine(string.Format(" *Type: {0}", this.GetType().Name));
            output.AppendLine(string.Format(" *Health: {0}", this.HealthPoints));
            output.AppendLine(string.Format(" *Attack: {0}", this.AttackPoints));
            output.AppendLine(string.Format(" *Defense: {0}", this.DefensePoints));
            output.AppendLine(string.Format(" *Targets: {0}", targetsOrNone));

            return output.ToString().Trim();
        }
    }
}
