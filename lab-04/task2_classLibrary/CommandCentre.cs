using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_classLibrary
{
    public class CommandCentre : IAirTrafficMediator
    {
        private List<Runway> runways = new List<Runway>();
        private List<Aircraft> aircrafts = new List<Aircraft>();


        public CommandCentre(IEnumerable<Runway> runways)
        {
            this.runways.AddRange(runways);
        }

        public void RegisterAircraft(Aircraft aircraft)
        {
            aircrafts.Add(aircraft);
        }

        public void RequestLanding(Aircraft aircraft)
        {
            foreach (var runway in runways)
            {
                if (runway.IsAvailable)
                {
                    runway.Occupy(aircraft);
                    return;
                }
            }
            Console.WriteLine($"No available runways for Aircraft {aircraft.Name}.");
        }

        public void NotifyTakeOff(Aircraft aircraft)
        {
            foreach (var runway in runways)
            {
                if (runway.OccupiedBy == aircraft)
                {
                    runway.Release();
                    return;
                }
            }
            Console.WriteLine($"Aircraft {aircraft.Name} is not on any runway.");
        }
    }
}
