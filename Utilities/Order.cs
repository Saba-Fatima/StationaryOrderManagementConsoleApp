using StationaryOrderManagementApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryOrderManagementApp.Utilities
{
    public class Order
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public int DueDate { get; set; }
        public List<IProduct> Products { get; } = new List<IProduct>();

        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }

        public void GenerateInvoiceReport()
        {
            Console.WriteLine("Your invoice report has been generated:");
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: 0");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("|                 |      Blue       |      Black      |       Red       |");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var product in Products)
            {
                Console.Write($"| {product.Name,-15}");

                Console.Write($"| {GetQuantity(product.Quantities, "Blue"),-15}");
                Console.Write($"| {GetQuantity(product.Quantities, "Black"),-15}");
                Console.Write($"| {GetQuantity(product.Quantities, "Red"),-15}");
                Console.WriteLine("|");
            }

            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var product in Products)
            {
                double totalPrice = GetTotalQuantity(product.Quantities) * product.Price;

                Console.WriteLine($"{product.Name + "s",-15} {GetTotalQuantity(product.Quantities)} @ ${product.Price} Producer Price Index = ${totalPrice}");
            }
        }

        public void GenerateStationeryReport()
        {
            Console.WriteLine("Your stationery report has been generated:");
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: 0");
            Console.WriteLine("--------------------");
            Console.WriteLine("|         |   Qty   |");
            Console.WriteLine("--------------------");

            foreach (var product in Products)
            {
                Console.WriteLine($"| {product.Name,-7} | {GetTotalQuantity(product.Quantities),-6} |");
            }

            Console.WriteLine("--------------------");
        }


        public void GenerateColorReport()
        {
            Console.WriteLine("Your color report has been generated:");
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: 0");
            Console.WriteLine("---------------------------------------------------------------------------");
            Console.WriteLine("|                 |      Blue       |      Black      |       Red       |");
            Console.WriteLine("---------------------------------------------------------------------------");

            foreach (var product in Products)
            {
                Console.Write($"| {product.Name,-15}");

                Console.Write($"| {GetQuantity(product.Quantities, "Blue"),-15}");
                Console.Write($"| {GetQuantity(product.Quantities, "Black"),-15}");
                Console.Write($"| {GetQuantity(product.Quantities, "Red"),-15}");
                Console.WriteLine("|");
            }

            Console.WriteLine("---------------------------------------------------------------------------");
        }

        private int GetQuantity(Dictionary<string, int> quantities, string color)
        {
            return quantities.ContainsKey(color) ? quantities[color] : 0;
        }

        private double GetTotalQuantity(Dictionary<string, int> quantities)
        {
            double total = 0;
            foreach (var quantity in quantities)
            {
                total += quantity.Value;
            }
            return total;
        }
    }
}
