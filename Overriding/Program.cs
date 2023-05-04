using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overriding
{
    public class Animal
    {
        public virtual void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dog : Animal
    {
        public override void eat()
        {
            //base.eat();
            Console.WriteLine("Eating bread...");
        }
    }
    public class Program
    {
        public static void Main()
        {
            Dog d = new Dog();
            d.eat();
            Console.ReadKey();
        }
    }
}
