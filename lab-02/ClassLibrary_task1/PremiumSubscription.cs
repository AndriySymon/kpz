using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public class PremiumSubscription : Subscription
    {
        public PremiumSubscription() : base("Premium", 19.99, 12, new List<string> { "All Channels" }, new List<string> { "4K Quality", "Multi-Screen" }) { }
    }
}
