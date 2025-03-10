using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public class ManagerCall : ISubscriptionCreator
    {
        public Subscription CreateSubscription(string type)
        {
            Console.WriteLine("Creating subscription via Manager Call...");
            return SubscriptionFactory.CreateSubscription(type);
        }
    }
}
