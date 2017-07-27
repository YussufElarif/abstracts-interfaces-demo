using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = new FruitList();

            t.Add(new Apple());
            t.Add(new Banana());
            t.Add(new BlueBerry());

            foreach (var fruit in t)
            {
                PrintfruitName(fruit);
            }

            Console.WriteLine($"I have {t.Getcountall()} Fruit");
            Console.WriteLine($"I have {t.CountOfFruit<Apple>()} Apples");

            Console.ReadKey();
        }

        static void PrintfruitName(IFruit f)
        {
            var bob = f.GetType().GetProperties();
            Console.WriteLine(f.Name);
        }


    }
}
