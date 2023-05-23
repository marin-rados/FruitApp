using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Orange : Fruit
    {
        public string Color { get; set; }
        public override string Name
        {
            get
            {
                return "Orange";
            }
        }

        public override int Quantity
        {
            get
            {
                return 5;
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
