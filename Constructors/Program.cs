using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    //Default Contructor
    public class Employee
    {
        public Employee()
        {
            Console.WriteLine("Default Constructor Invoked");
        }
    }
    class TestEmployee
    {
        public static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee();

            Console.ReadKey();
        }
    }

    //Perameterized Constructor
    //public class Employee
    //{
    //    public int id;
    //    public string name;
    //    public float salary;
    //    public Employee(int i, string n, float s)
    //    {
    //        this.id = i;
    //        this.name = n;
    //        this.salary = s;
    //    }
    //    public void display()
    //    {
    //        Console.WriteLine(id + " " + name + " " + salary);
    //    }
    //}
    //class TestEmployee
    //{
    //    public static void Main(string[] args)
    //    {
    //        Employee e1 = new Employee(101, "Rajesh", 890000f);
    //        Employee e2 = new Employee(102, "Mahesh", 490000f);
    //        e1.display();
    //        e2.display();
    //        Console.ReadKey();

    //    }
    //}
}
