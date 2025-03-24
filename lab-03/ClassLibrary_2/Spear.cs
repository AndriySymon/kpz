using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_2
{
    public class Spear : InventoryDecorator
    {
        public Spear(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with a Spear";
        public override int GetPower() => hero.GetPower() + 2;
    }
}
