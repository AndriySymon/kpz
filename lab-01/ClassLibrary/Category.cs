using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Category
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }

        public Category(string name, string description, string department)
        {
            Name = name;
            Description = description;
            Department = department;
        }
    }

}
