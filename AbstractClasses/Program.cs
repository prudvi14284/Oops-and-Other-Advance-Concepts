using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    //Abstract class
    public abstract class Shape
    {
        public abstract void draw();
    }
    public class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing rectangle...");
        }
    }
    public class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("drawing circle...");
        }
    }
    public class TestAbstract
    {
        public static void Main()
        {
            Shape s;
            s = new Rectangle();
            s.draw();

            s = new Circle();
            s.draw();
            Console.ReadKey();
        }
    }


    ////Create abstract class. Can't create objects
    //abstract class Person
    //{
    //    //Properties
    //    public string Name;
    //    public string Gender;

    //    public void Display()
    //    {
    //        Console.WriteLine("Person name: " + this.Name);
    //        Console.WriteLine("Gender: " + this.Gender);
    //    }
    //}

    ////Child Class1 child class can create objets
    //class Student : Person
    //{
    //    public int StudentID;
    //    public int Marks;
    //}

    ////child class 2
    //class Employee : Person
    //{
    //    public int EmpID;
    //    public double Salary;
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Create object for child class1
    //        Student s;
    //        s = new Student();
    //        s.Name = "Kiran";
    //        s.Gender = "Male";
    //        s.StudentID = 101;
    //        s.Marks = 70;
    //        s.Display();
    //        Console.WriteLine("Student ID: " + s.StudentID);
    //        Console.WriteLine("Marks: " + s.Marks);
    //        Console.WriteLine("\n");

    //        //Create object for child class2
    //        Employee emp;
    //        emp = new Employee();
    //        emp.Name = "Prudvi";
    //        emp.Gender = "Male";
    //        emp.EmpID = 201;
    //        emp.Salary = 50000;
    //        emp.Display();
    //        Console.WriteLine("Employee ID: " + emp.EmpID);
    //        Console.WriteLine("Salary: " + emp.Salary);
    //        Console.ReadKey();
    //    }
    //}
}
