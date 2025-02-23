using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating a new Money object...");
            Money money1 = new Money(100, 25, "USD");
            Money money2 = new Money(200, 25, "USD");
            Money money3 = new Money(150, 75, "USD");
            Console.WriteLine(money2.Display());

            Console.WriteLine("Creating a new Category object...");
            Category category1 = new Category("Fruit", "Edible item", "Food");
            Console.WriteLine($"Name: {category1.Name}, Description: {category1.Description}, Type: {category1.Department}");
            Category category2 = new Category("Vegetable", "Edible item", "Food");
            Console.WriteLine($"Name: {category2.Name}, Description: {category2.Description}, Type: {category2.Department}");
            Category category3 = new Category("Dairy", "Edible item", "Food");
            Console.WriteLine($"Name: {category3.Name}, Description: {category3.Description}, Type: {category3.Department}");


            Console.WriteLine("Creating new Product objects...");
            Product product1 = new Product("Apple", money1, category1, "Kg", 200, DateTime.Now.AddDays(-10));
            Product product2 = new Product("Milk", money2, category2, "Litre", 100, DateTime.Now.AddDays(-5));
            Product product3 = new Product("Bread", money3, category3, "Piece", 150, DateTime.Now.AddDays(-2));
            Console.WriteLine("Reducing product prices...");
            product1.ReducePrice(10);
            product2.ReducePrice(20);
            product3.ReducePrice(15);
            Console.WriteLine($"Product: {product1.Name}, Price: {product1.Price.Display()}, Category: {product1.Category.Name}");
            Console.WriteLine($"Product: {product2.Name}, Price: {product2.Price.Display()}, Category: {product2.Category.Name}");
            Console.WriteLine($"Product: {product3.Name}, Price: {product3.Price.Display()}, Category: {product3.Category.Name}");

            Console.WriteLine("Creating a new Warehouse object...");
            Warehouse warehouse = new Warehouse();

            Console.WriteLine("Adding products to the warehouse...");
            warehouse.AddProduct(product1);
            warehouse.AddProduct(product2);
            warehouse.AddProduct(product3);

            Console.WriteLine("Creating a new Reporting object...");
            Reporting reporting = new Reporting(warehouse);

            Console.WriteLine("Registering product receipts...");
            reporting.RegisterProductReceipt(product1, 10, "2024-03-05");
            reporting.RegisterProductReceipt(product2, 20, "2024-03-06");
            reporting.RegisterProductReceipt(product3, 15, "2024-03-07");

            Console.WriteLine("Generating an inventory report...");
            reporting.InventoryReport();

            ShoppingCart shoppingCart = new ShoppingCart();

            bool addingProducts = true;
            while (addingProducts)
            {
                Console.WriteLine("Enter the name of the product you want to add to the cart (or 'stop' to finish):");
                string productName = Console.ReadLine();

                if (productName.ToLower() == "stop")
                {
                    addingProducts = false;
                }
                else
                {

                    Product productToAdd = warehouse.GetProducts().Find(p => p.Name == productName);

                    if (productToAdd != null)
                    {
                        shoppingCart.AddProduct(productToAdd);
                        Console.WriteLine($"Product '{productName}' has been added to the cart.");
                    }
                    else
                    {
                        Console.WriteLine($"Product with the name '{productName}' not found.");
                    }
                }
            }

            Console.WriteLine("Displaying the total cost of the cart...");
            Console.WriteLine(shoppingCart.TotalCost().Display());
        }
    }
}
