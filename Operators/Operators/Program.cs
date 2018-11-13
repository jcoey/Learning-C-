using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // arithmetic operations
            int a =10;
            int b = 20;
            int c = 30;
            int result = a + b + c;
            Console.WriteLine("the sum of " + a + " , " + b + " less " + c + " is " +(a + (b - c) ));
            Console.WriteLine("the modulus is obtained by using the operator %: " + (c % a));
            Console.WriteLine("And we can also divide two integers..." + (b/a));
            // Relational operators
            Console.WriteLine("Is " + a + "greater than or equal to " + b + " ? " + (a >= b));
            Console.WriteLine("is " + a + "Equal to or less than  " + c + " ? "+ (a <= c));
            // logical operators
            bool value;
            bool x = true;
            value = (a <= b) && (c >= a);
            Console.WriteLine(value);
           value=!x;
            Console.WriteLine(value);
            value = (a >= b) || (c >= b);
            Console.WriteLine(value);   
           // bitwise operators.
            int y = 12;
            int z = 5;
           result =  y & z;
            Console.WriteLine(result);           
            result = y | z;
            Console.WriteLine(result);
            result = y ^ z;
            Console.WriteLine(result);
            result = y >> 2;
            Console.WriteLine(result);
            result =y << 3;
            Console.WriteLine(result);
            // assignment operator
            y += 10;
            Console.WriteLine(y);
            y -= 20;
            Console.WriteLine(y);
            y *= 10;
            Console.WriteLine(y);
            y /= 5;
            Console.WriteLine(y);
            y %= 2;
            Console.WriteLine(y);
            Console.ReadKey();

        }
    }
}
