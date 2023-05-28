using Microsoft.VisualBasic;
using StationaryOrderManagementApp.DAL;
using StationaryOrderManagementApp.DAO;
using StationaryOrderManagementApp.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Xml.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order();

        Console.WriteLine("Please enter your name:");
        order.Name = Console.ReadLine();

        Console.WriteLine("Please enter your address:");
         order.Address = Console.ReadLine();

        Console.WriteLine("Please enter the due date:");
        order.DueDate = ConsoleInputReader.ReadIntInput("Due Date (YYYYMMDD):");

        Marker marker = new Marker();
        Pen pen = new Pen();
        Pencil pencil = new Pencil();

        ConsoleInputReader.EnterItemQuantities(marker, "Marker");
        ConsoleInputReader.EnterItemQuantities(pen, "Pen");
        ConsoleInputReader.EnterItemQuantities(pencil, "Pencil");

        order.AddProduct(marker);
        order.AddProduct(pen);
        order.AddProduct(pencil);

        order.GenerateInvoiceReport();
        order.GenerateStationeryReport();
        order.GenerateColorReport();
    }
   
}


