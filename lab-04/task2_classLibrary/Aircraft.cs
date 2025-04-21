using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_classLibrary
{
    public class Aircraft
    {
        public string Name { get; set; }
        public bool IsTakingOff { get; set; }
        private IAirTrafficMediator mediator;

        public Aircraft(string name, IAirTrafficMediator mediator)
        {
            this.Name = name;
            this.mediator = mediator;
        }

        public void Land()
        {
            Console.WriteLine($"\nAircraft {Name} requests landing...");
            mediator.RequestLanding(this);
        }

        public void TakeOff()
        {
            Console.WriteLine($"\nAircraft {Name} is preparing for takeoff...");
            this.IsTakingOff = true;
            mediator.NotifyTakeOff(this);
        }
    }
}
