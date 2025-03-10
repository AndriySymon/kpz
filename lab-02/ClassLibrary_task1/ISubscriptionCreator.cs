using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public interface ISubscriptionCreator
    {
        Subscription CreateSubscription(string type);
    }
}
