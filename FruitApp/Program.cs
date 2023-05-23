using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FruitApp
{
    public class Program
    {
        static void Main(string[] args)
        {

            List<Fruit> fruit = new List<Fruit>();
            fruit.Add(new Banana());
            fruit.Add(new Apple());
            fruit.Add(new Lemon());
            fruit.Add(new Orange());
            fruit.Add(new Melon());
            
            for (int i = 0; i < fruit.Count; i++)
            {
                Console.WriteLine(fruit[i].ToString());
            }

            Console.Read();
        }
    }
}
