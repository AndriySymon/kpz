using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_2
{
    public class Sword : InventoryDecorator
    {
        public Sword(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " with a Sword";
        public override int GetPower() => hero.GetPower() + 5;
    }
}
