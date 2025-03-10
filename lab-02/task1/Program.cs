using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary_task1;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            ISubscriptionCreator website = new WebSite();
            ISubscriptionCreator mobileApp = new MobileApp();
            ISubscriptionCreator managerCall = new ManagerCall();

            Subscription sub1 = website.CreateSubscription("Domestic");
            sub1.DisplayInfo();

            Subscription sub2 = mobileApp.CreateSubscription("Educational");
            sub2.DisplayInfo();

            Subscription sub3 = managerCall.CreateSubscription("Premium");
            sub3.DisplayInfo();
        }
    }
}
