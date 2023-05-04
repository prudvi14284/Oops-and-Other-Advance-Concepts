using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Animal // Abstract class
    {
        public abstract void animalSound(); // Abstract Method
    }


    class Dog : Animal // Child Class
    {
        public override void animalSound()
        {
            Console.WriteLine("This dog says: Bow Bow");
        }
    }

    class Cat : Animal // Child Class
    {
        public override void animalSound()
        {
            Console.WriteLine("This cat says: Meow Meow");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal dog = new Dog();
            dog.animalSound();

            Animal cat = new Cat();
            cat.animalSound();

            Console.ReadKey();
        }
    }
}
