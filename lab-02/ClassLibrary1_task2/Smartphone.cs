using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_task2
{
    public class Smartphone : IDevice
    {
        private string brand;
        public Smartphone(string brand) => this.brand = brand;
        public void ShowInfo() => Console.WriteLine($"{brand} Smartphone created.");
    }
}
