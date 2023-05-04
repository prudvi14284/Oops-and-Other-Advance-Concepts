using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    public class Calculation
    {
        public static int add(int a, int b)
        {
            return a + b;
        }
        public static int add(int a, int b, int c)
        {
            return a + b + c;
        }
        public static float add(float a, float b, float c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.add(20, 30));
            Console.WriteLine(Calculation.add(35, 84, 95));
            Console.WriteLine(Calculation.add(3.50F, 8.40F, 9.50F));
            Console.ReadKey();
        }
    }
}
