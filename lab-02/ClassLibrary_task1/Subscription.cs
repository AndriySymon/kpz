using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_task1
{
    public abstract class Subscription
    {
        public string Name { get; }
        public double MonthlyFee { get; }
        public int MinimumPeriod { get; }
        public List<string> Channels { get; }
        public List<string> Features { get; }

        protected Subscription(string name, double monthlyFee, int minimumPeriod, List<string> channels, List<string> features)
        {
            Name = name;
            MonthlyFee = monthlyFee;
            MinimumPeriod = minimumPeriod;
            Channels = channels;
            Features = features;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Subscription: {Name}\nMonthly Fee: {MonthlyFee}$\nMinimum Period: {MinimumPeriod} months\nChannels: {string.Join(", ", Channels)}\nFeatures: {string.Join(", ", Features)}\n");
        }
    }
}
