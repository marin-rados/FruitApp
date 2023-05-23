using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public interface IFruit
    {
        int Quantity { get; set; }
        bool IsSweet { get; set; }
        string Name { get; set; }
    }
}
