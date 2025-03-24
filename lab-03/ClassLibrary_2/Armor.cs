using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_2
{
    public class Armor : InventoryDecorator
    {
        public Armor(IHero hero) : base(hero) { }

        public override string GetDescription() => hero.GetDescription() + " wearing Armor";
        public override int GetPower() => hero.GetPower() + 3;
    }
}
