using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Class1
    {

        // Method 1
        public void M1()
        {
            Console.WriteLine("Method Name: M1");
        }

        // Method 2
        public void M2()
        {
            Console.WriteLine("Method Name: M2");
        }

        // Method 3
        public void M3()
        {
            Console.WriteLine("Method Name: M3");
        }

    }

    static class Class2
    {
  
        //By using Binding parameters to add the method to the class1
        // Method 4
        public static void M4(this Class1 a)
        {
            Console.WriteLine("Method Name: M4");
        }
  
        // Method 5
        public static void M5(this Class1 a, string str)
        {
            Console.WriteLine(str);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 c = new Class1();
            c.M1();
            c.M2();
            c.M3();
            c.M4();
            c.M5("Method Name: M5");
            Console.ReadKey();
        }
    }
}
