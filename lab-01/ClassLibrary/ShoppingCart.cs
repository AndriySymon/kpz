using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ShoppingCart
    {
        private List<Product> Products { get; set; }

        public ShoppingCart()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            if (product == null)
            {
                throw new ArgumentNullException(nameof(product));
            }
            Products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            Products.Remove(product);
        }

        public IMoney TotalCost()
        {
            int totalWholePart = 0;
            int totalFractionalPart = 0;
            string currency = Products[0].Price.Currency;

            foreach (var product in Products)
            {
                totalWholePart += product.Price.WholePart;
                totalFractionalPart += product.Price.FractionalPart;
            }

            totalWholePart += totalFractionalPart / 100;
            totalFractionalPart %= 100;

            return new Money(totalWholePart, totalFractionalPart, currency);
        }
    }
}
