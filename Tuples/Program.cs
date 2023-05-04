using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating Tuple of three values  
            var book = new Tuple<string, string, double>("C# in Depth", "Jon Skeet", 100.50);
            
            Console.WriteLine("Title  " + book.Item1);
            Console.WriteLine("Author " + book.Item2);
            Console.WriteLine("Price  " + book.Item3);
            Console.ReadKey();
        }
    }
}
