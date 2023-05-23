using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Apple : Fruit
    {
        public string Color { get; set; }
        public string AppleVariety { get; set; }
        public override string Name
        {
            get
            {
                return "Fuji";
            }
        }

        public override int Quantity
        {
            get
            {
                return 3;
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
