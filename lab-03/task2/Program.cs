using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_2;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IHero warrior = new Warrior();
            Console.WriteLine($"{warrior.GetDescription()} - Power: {warrior.GetPower()}");

            warrior = new Sword(warrior);
            warrior = new Armor(warrior);
            Console.WriteLine($"{warrior.GetDescription()} - Power: {warrior.GetPower()}");

            IHero mage = new Mage();
            mage = new Spear(mage);
            Console.WriteLine($"{mage.GetDescription()} - Power: {mage.GetPower()}");
        }
    }
}
