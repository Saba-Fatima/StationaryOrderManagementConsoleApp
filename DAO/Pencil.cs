using StationaryOrderManagementApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryOrderManagementApp.DAO
{
    public class Pencil : IProduct
    {
        public string Name => "Pencil";
        public Dictionary<string, int> Quantities { get; } = new Dictionary<string, int>();

        public double Price => 1.0;
    }
}
