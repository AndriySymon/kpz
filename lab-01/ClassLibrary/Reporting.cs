using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Reporting
    {
        public Warehouse Warehouse { get; set; }

        public Reporting(Warehouse warehouse)
        {
            Warehouse = warehouse;
        }

        public void RegisterProductReceipt(Product product, int quantity, string date)
        {
            Warehouse.AddProduct(product);
        }

        public void InventoryReport()
        {
            foreach (var product in Warehouse.GetProducts())
            {
                Console.WriteLine($"Product: {product.Name}, Price: {product.Price.Display()}, Category: {product.Category.Name}, Unit of Measure: {product.UnitOfMeasure}, Quantity: {product.Quantity}, Last Delivery Date: {product.LastDeliveryDate}");
            }
        }
    }
}
