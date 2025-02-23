using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Money : IMoney
    {
        public int WholePart { get; set; }
        public int FractionalPart { get; set; }
        public string Currency { get; set; }

        public Money(int wholePart, int fractionalPart, string currency)
        {
            WholePart = wholePart;
            FractionalPart = fractionalPart;
            Currency = currency;
        }

        public string Display()
        {
            return $"{WholePart}.{FractionalPart} {Currency}";
        }
    }
}
