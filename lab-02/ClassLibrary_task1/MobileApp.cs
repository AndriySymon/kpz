using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public class MobileApp : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Creating subscription via Mobile App...");
            return SubscriptionFactory.CreateSubscription(type);
        }
    }
}
