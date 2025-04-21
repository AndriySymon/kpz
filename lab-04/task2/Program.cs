using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using task2_classLibrary;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var runway1 = new Runway();
            var runway2 = new Runway();

            var controlTower = new CommandCentre(new[] { runway1, runway2 });

            var aircraft1 = new Aircraft("EMB-110C", controlTower);
            var aircraft2 = new Aircraft("EMB-110P", controlTower);
            var aircraft3 = new Aircraft("AN-225", controlTower);

            controlTower.RegisterAircraft(aircraft1);
            controlTower.RegisterAircraft(aircraft2);
            controlTower.RegisterAircraft(aircraft3);

            aircraft1.Land();
            aircraft2.Land();
            aircraft3.Land();

            aircraft1.TakeOff();
            aircraft3.Land();
        }
    }
}
