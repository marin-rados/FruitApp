using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitApp
{
    public abstract class Fruit: IFruit
    {
        public virtual int Quantity { get; set; }
        public virtual bool IsSweet { get; set; }
        public virtual string Name { get; set; }

        public override string ToString()
        {
            return "My name is: " + Name + " There is " + Quantity + " of me " + "and I am " + (IsSweet? "sweet! :)" : "not sweet! :(");
        }
    }
}
