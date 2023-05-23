using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Banana: Fruit
    {
        public string Color { get; set; }
        public string BananaVariety { get; set; }
        public override string Name
        {
            get
            {
                return "Bannannaa";
            }
        }

        public override int Quantity
        {
            get
            {
                return 4;
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
