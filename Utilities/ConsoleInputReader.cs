using StationaryOrderManagementApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryOrderManagementApp.Utilities
{
    public class ConsoleInputReader
    {
        public static int ReadIntInput(string message)
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input))
            {
                Console.WriteLine("Invalid input. Please enter a valid number:");
            }
            return input;
        }
        public static void EnterItemQuantities(IProduct item, string itemType)
        {
            Console.WriteLine($"Please enter the number of Blue {itemType}s:");
            item.Quantities["Blue"] = ConsoleInputReader.ReadIntInput("");
            Console.WriteLine($"Please enter the number of Black {itemType}s:");
            item.Quantities["Black"] = ConsoleInputReader.ReadIntInput("");
            Console.WriteLine($"Please enter the number of Red {itemType}s:");
            item.Quantities["Red"] = ConsoleInputReader.ReadIntInput("");
        }
    }
}
