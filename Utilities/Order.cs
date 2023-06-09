﻿using StationaryOrderManagementApp.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryOrderManagementApp.Utilities
{
    public class Order
    {
        [Required(ErrorMessage = "Name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        public string Address { get; set; }

        [Required(ErrorMessage = "Due Date is required.")]
        public int DueDate { get; set; }

        public int OrderNumber = 1;
        public List<IProduct> Products { get; } = new List<IProduct>();
        public void AddProduct(IProduct product)
        {
            Products.Add(product);
        }
        public void GenerateInvoiceReport()
        {
            Console.WriteLine("Your invoice report has been generated:");
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: {OrderNumber}");
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
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: {OrderNumber}");
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
            Console.WriteLine($"Name: {Name} Address: {Address} Due Date: {DueDate} Order #: {OrderNumber}");
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
            if (quantities.ContainsKey(color))
                return quantities[color];
            return 0;
        }

        private int GetTotalQuantity(Dictionary<string, int> quantities)
        {
            int total = 0;
            foreach (var quantity in quantities.Values)
            {
                total += quantity;
            }
            return total;
        }

    }
}
