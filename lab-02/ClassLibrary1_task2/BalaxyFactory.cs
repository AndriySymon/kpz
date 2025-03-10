using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1_task2
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Balaxy");
        public IDevice CreateNetbook() => new Netbook("Balaxy");
        public IDevice CreateEBook() => new EBook("Balaxy");
        public IDevice CreateSmartphone() => new Smartphone("Balaxy");
    }
}
