using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpMethod
{
    class Person
    {
        public int age;
    }

        class Program

        {

            static void Square(Person a, Person b)

            {
                a.age = a.age * a.age;
                b.age = b.age * b.age;
                System.Console.WriteLine(a.age + " " + b.age);
            }
            static void Main(string[] args)
            {
                Person p1 = new Person();

                Person p2 = new Person();

                p1.age = 5;
                p2.age = 10;
                System.Console.WriteLine(p1.age + " " + p2.age);
                Square(p1, p2);
                System.Console.WriteLine(p1.age + " " + p2.age);
                // Basic C Sharp Hello world
                System.Console.WriteLine("Hello World");
            //Datatypes in c#.... datatype used to define type of data a variable will hold... eg integers, strings, datetime...double..
            int a = 9;
            int b = 10;
            int result = a + b;
            System.Console.WriteLine("The sum of " + a + " and " + b + " is " + result);
            DateTime time = DateTime.Now;
            System.Console.WriteLine("Today is on " + time);
            Double c = 10.0;
            System.Console.WriteLine(c);

            // to ensure that the console on closes after pressing any key thus giving time to the user to view the result.
            System.Console.ReadKey();
            }
    }

}
