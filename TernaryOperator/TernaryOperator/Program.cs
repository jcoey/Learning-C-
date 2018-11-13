using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TernaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //ternary operator(?:)
            // it is a decision making operator used as a substitute of if---else statement in c#
            // conditional-expression ? first-operand:secondOperand
            int x = 200;
            int y = 100;
            string result;
            result = (x >= y )?"200 is greater than 100":"100 is less than 200";
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
