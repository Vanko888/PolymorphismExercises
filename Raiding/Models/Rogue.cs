using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Rogue : BaseHero
    {
        public Rogue(string name) : base(name)
        { }

        public override int Power => GlobalConstants.RogueAndDruidPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideRodueWarrior, GetType().Name, Name, Power);
        }
    }
}
