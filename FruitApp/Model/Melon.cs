using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Melon: Fruit
    {
        public bool IsWatery { get; set; }
        public override string Name
        {
            get
            {
                return "Melon";
            }
        }

        public override int Quantity
        {
            get
            {
                return 2;
            }
        }

        public override bool IsSweet
        {
            get
            {
                return true;
            }
        }
    }
}
