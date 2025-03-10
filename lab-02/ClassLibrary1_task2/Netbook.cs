using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_task2
{
    public class Netbook : IDevice
    {
        private string brand;
        public Netbook(string brand) => this.brand = brand;
        public void ShowInfo() => Console.WriteLine($"{brand} Netbook created.");
    }
}
