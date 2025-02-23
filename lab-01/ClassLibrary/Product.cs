using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Product
    {
        public string Name { get; set; }
        public IMoney Price { get; set; }
        public Category Category { get; set; }
        public string UnitOfMeasure { get; set; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public Product(string name, IMoney price, Category category, string unitOfMeasure, int quantity, DateTime lastDeliveryDate)
        {
            Name = name;
            Price = price;
            Category = category;
            UnitOfMeasure = unitOfMeasure;
            Quantity = quantity;
            LastDeliveryDate = lastDeliveryDate;
        }

        public void ReducePrice(int amount)
        {
            if (Price.WholePart < amount)
            {
                throw new Exception("The reduction amount cannot be greater than the product price.");
            }
            Price.WholePart -= amount;
        }
    }
}
