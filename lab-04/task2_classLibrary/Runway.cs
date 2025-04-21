using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2_classLibrary
{
    public class Runway
    {
        public Guid Id = Guid.NewGuid();
        public Aircraft OccupiedBy;

        public bool IsAvailable
        {
            get { return OccupiedBy == null; }
        }

        public void Occupy(Aircraft aircraft)
        {
            OccupiedBy = aircraft;
            Console.WriteLine("Aircraft " + aircraft.Name + " has landed on Runway " + Id);
            HighLightRed();
        }

        public void Release()
        {
            if (OccupiedBy != null)
            {
                Console.WriteLine("Aircraft " + OccupiedBy.Name + " took off from Runway " + Id);
            }
            OccupiedBy = null;
            HighLightGreen();
        }

        public void HighLightRed()
        {
            Console.WriteLine("Runway " + Id + " is busy.");
        }

        public void HighLightGreen()
        {
            Console.WriteLine("Runway " + Id + " is free.");
        }
    }
}
