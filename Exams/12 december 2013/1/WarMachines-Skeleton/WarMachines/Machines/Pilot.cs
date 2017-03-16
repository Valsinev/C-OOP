
namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using WarMachines.Interfaces;

    class Pilot : IPilot
    {
        private string name;
        private ICollection<IMachine> engagableMachines;

        public Pilot(string name)
        {
            this.Name = name;
            this.engagableMachines = new List<IMachine>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            protected set
            {
                Validator.NullOrEmptyString(value, "Pilot name cannot be null or empty!");
                this.name = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            Validator.NullObject(machine, "Machine to add cannot be null!");
            this.engagableMachines.Add(machine);
        }

        public string Report()
        {
            var output = new StringBuilder();
            string numberMachinesOrNo = this.engagableMachines.Count == 0 ? "no" : this.engagableMachines.Count.ToString();
            string ifPlural = this.engagableMachines.Count == 1 ? "machine" : "machines";
            var sortedMachines = this.engagableMachines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            output.AppendLine(string.Format("{0} – {1} {2}", this.Name, numberMachinesOrNo, ifPlural));
            foreach (var machine in sortedMachines)
            {
                output.AppendLine(machine.ToString().Trim());
            }
            return output.ToString().Trim();
        }
    }
}
