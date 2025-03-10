using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1_task2;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeviceFactory factory = new IProneFactory();
            IDevice laptop = factory.CreateLaptop();
            IDevice smartphone = factory.CreateSmartphone();
            laptop.ShowInfo();
            smartphone.ShowInfo();

            factory = new KiaomiFactory();
            IDevice netbook = factory.CreateNetbook();
            netbook.ShowInfo();
        }
    }
}
