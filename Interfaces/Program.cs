using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface Drawable
    {
        void draw(); // interface method (does not have a body)
    }
    public class Rectangle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Drawable
    {
        public void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestInterface
    {
        public static void Main()
        {
            Drawable d;
            d = new Rectangle();
            d.draw();
            d = new Circle();
            d.draw();
            Console.ReadKey();
        }
    }

    //// Interface
    //interface IAnimal
    //{
    //    void animalSound(); // interface method (does not have a body)
    //}

    //// Dog "implements" the IAnimal interface
    //class Dog : IAnimal
    //{
    //    public void animalSound()
    //    {
    //        // The body of animalSound() is provided here
    //        Console.WriteLine("The dog says: bow bow");
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Dog d = new Dog();  // Create a Dog object
    //        d.animalSound();
    //        Console.ReadKey();
    //    }
    //}
}
