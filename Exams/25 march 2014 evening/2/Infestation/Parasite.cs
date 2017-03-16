using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infestation
{
    public class Parasite : InfestUnit
    {
        const int ParasitePower = 1;
        const int ParasiteHealth = 1;
        const int ParasiteAggression = 1;

        public Parasite(string id) 
            : base(id, UnitClassification.Biological,Parasite.ParasiteHealth,Parasite.ParasitePower, Parasite.ParasiteAggression)
        {
        }
        protected override UnitInfo GetOptimalAttackableUnit(IEnumerable<UnitInfo> attackableUnits)
        {
            UnitInfo optimalAttackableUnit = new UnitInfo(null, UnitClassification.Unknown, 0, int.MaxValue, 0);

            var targetsDifferentThanItself = attackableUnits.Where(u => u.GetType().Name != this.GetType().Name);
            foreach (var target in targetsDifferentThanItself)
            {
                optimalAttackableUnit = targetsDifferentThanItself.OrderBy(u => u.Health).FirstOrDefault();
            }
            return optimalAttackableUnit;
        }

        public override Interaction DecideInteraction(IEnumerable<UnitInfo> units)
        {
            IEnumerable<UnitInfo> attackableUnits = units.Where((unit) => this.CanAttackUnit(unit));

            UnitInfo optimalAttackableUnit = GetOptimalAttackableUnit(attackableUnits);

            if (optimalAttackableUnit.Id != null)
            {
                return new Interaction(new UnitInfo(this), optimalAttackableUnit, InteractionType.Infest);
            }

            return Interaction.PassiveInteraction;
        }

        protected override bool CanAttackUnit(UnitInfo unit)
        {
            bool attackUnit = false;
            if (this.Id != unit.Id)
            {
                if (this.GetType().Name != unit.GetType().Name)
                {
                    attackUnit = true;
                }
            }
            return attackUnit;
        }
    }
}
