using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StationaryOrderManagementApp.DAL
{
    public interface IProduct
    {
        string Name { get; }
        Dictionary<string, int> Quantities { get; }

        double Price { get; }
    }
}
