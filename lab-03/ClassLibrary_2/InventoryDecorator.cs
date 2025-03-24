using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_2
{
    public abstract class InventoryDecorator : IHero
    {
        protected IHero hero;

        public InventoryDecorator(IHero hero)
        {
            this.hero = hero;
        }
        public virtual string GetDescription() => hero.GetDescription();
        public virtual int GetPower() => hero.GetPower();
    }
}
