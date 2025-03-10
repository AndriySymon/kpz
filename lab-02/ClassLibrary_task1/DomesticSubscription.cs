using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public class DomesticSubscription : Subscription
    {
        public DomesticSubscription() : base("Domestic", 10.99, 6, new List<string> { "News", "Entertainment", "Sports" }, new List<string> { "HD Quality" }) { }
    }
}
