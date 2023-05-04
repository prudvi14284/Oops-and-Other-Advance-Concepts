using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Vehicle  //Base class
    {
        public string brand = "Tata";
        public void honk()
        {
            Console.WriteLine("This is car");
        }

    }

    class Car : Vehicle  //Derived class
    {
        public string modelName = "XUV 100";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();
            myCar.honk();
            Console.WriteLine(myCar.brand + " " + myCar.modelName);
            Console.ReadKey();
        }
    }
}
