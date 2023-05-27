using StationaryOrderManagementApp.DAL;
using StationaryOrderManagementApp.DAO;
using StationaryOrderManagementApp.Utilities;
using System;

public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Please enter your Name:");
        string name = Console.ReadLine();

        Console.WriteLine("Please enter your Address:");
        string address = Console.ReadLine();

        Console.WriteLine("Please enter your Due Date:");
        int dueDate = int.Parse(Console.ReadLine());

        Order order = new Order
        {
            Name = name,
            Address = address,
            DueDate = dueDate
        };

        IProduct marker = new Marker();
        IProduct pen = new Pen();
        IProduct pencil = new Pencil();

        Console.WriteLine("Please enter the number of Blue Markers:");
        ((Marker)marker).Quantities["Blue"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Black Markers:");
        ((Marker)marker).Quantities["Black"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Red Markers:");
        ((Marker)marker).Quantities["Red"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Blue Pens:");
        ((Pen)pen).Quantities["Blue"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Black Pens:");
        ((Pen)pen).Quantities["Black"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Red Pens:");
        ((Pen)pen).Quantities["Red"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Blue Pencil:");
        ((Pencil)pencil).Quantities["Blue"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Black Pencil:");
        ((Pencil)pencil).Quantities["Black"] = int.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the number of Red Pencil:");
        ((Pencil)pencil).Quantities["Red"] = int.Parse(Console.ReadLine());

        order.AddProduct(marker);
        order.AddProduct(pen);
        order.AddProduct(pencil);

        order.GenerateInvoiceReport();
        Console.WriteLine();
        order.GenerateStationeryReport();
        Console.WriteLine();
        order.GenerateColorReport();

        Console.WriteLine("Press any key to continue . . .");
        Console.ReadKey();
    }
}

