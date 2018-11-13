using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            // conditional operators
            int w = 40;
            int z = 100;
            int y = 200;
            if(w >= z)
            {
                Console.WriteLine(" it is clear that " + w + " is greater than " + z);
            }
            else
            {
                Console.WriteLine("OPPS!!! " + w + " is less than " + z);
            }

            // if-elseif//
            if (w >= z)
            {
                Console.WriteLine(" it is clear that " + w + " is greater than " + z);
            }
            else if( y<=z)
            {
                Console.WriteLine("oooh!!! " + w + " is less than " + z);
            }
            else 
            {
                Console.WriteLine("we lost it!");
            }
            // nested if else statement.
            if (y >= z)
            {
                if (y == 100)
                {
                    Console.WriteLine("Its true that Y is greater than z and y = 200");
                }
                else if (y <= 10) 
                {
                    Console.WriteLine(y + " is greater than 10");
                }
                else
                {
                    Console.WriteLine("hmmm.... too bad");
                }
            }
            else
            {
                Console.WriteLine("Revisit all your variables");
            }

            Console.ReadKey();
        }

    }
}
