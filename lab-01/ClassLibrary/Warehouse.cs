using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Warehouse
    {
        private List<Product> Products { get; set; }

        public Warehouse()
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

        public List<Product> GetProducts()
        {
            return Products;
        }
    }
}
