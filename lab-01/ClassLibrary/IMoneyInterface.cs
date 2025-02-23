using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
        public interface IMoney
        {
            int WholePart { get; set; }
            int FractionalPart { get; set; }
            string Currency { get; set; }
            string Display();
        }
    }