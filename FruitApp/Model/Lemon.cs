using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Lemon: Fruit
    {
        public override string Name
        {
            get
            {
                return "LeeMoon";
            }
        }

        public override int Quantity
        {
            get
            {
                return 1;
            }
        }

        public override bool IsSweet
        {
            get
            {
                return false;
            }
        }
    }
}
