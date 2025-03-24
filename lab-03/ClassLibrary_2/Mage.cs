using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_2
{
    public class Mage : IHero
    {
        public string GetDescription() => "Mage";
        public int GetPower() => 8;
}
}
