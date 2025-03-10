using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public class EducationalSubscription : Subscription
    {
        public EducationalSubscription() : base("Educational", 7.99, 3, new List<string> { "Discovery", "National Geographic", "History" }, new List<string> { "No Ads", "Offline Access" }) { }
    }
}
