using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_task2
{
    public class Laptop : IDevice
    {
        private string brand;
        public Laptop(string brand) => this.brand = brand;
        public void ShowInfo() => Console.WriteLine($"{brand} Laptop created.");
    }
}
