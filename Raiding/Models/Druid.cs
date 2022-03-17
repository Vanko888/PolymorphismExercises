using System;
using System.Collections.Generic;
using System.Text;

namespace Raiding.Models
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        { }

        public override int Power => GlobalConstants.RogueAndDruidPower;

        public override string CastAbility()
        {
            return string.Format(GlobalConstants.StringOverrideDruidPaladin, GetType().Name, Name, Power);
        }
    }
}
