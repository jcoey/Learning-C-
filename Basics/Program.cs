using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Basics of c sharp.");
            System.Console.WriteLine("Hello World");

            //verbatim literal string... it ignores the escape sequence and includes white spaces.
            //verbatim identifier
            // uses a special character @.
            string[] @for = { "jem", "john", "mike", "myles" };
            for(int ctr = 0; ctr < @for.Length; ctr++)
            {
                System.Console.WriteLine($"Here is your letter, {@for[ctr]}!");
            }
            string path = @"the path is:c:\Windows\System32 ";
            System.Console.WriteLine(path);

            // string literal
            string name = "Jemmy";
            //tenary operator ?: it accepts  operands
            System.Console.WriteLine(name == "Wangui" ? "the name is " + name : "the name is not " + name);
            // short circuiting operator
            int a = 8;
            int b = 9;
            int c = a + b;
            string x = "The value of A was wrong";
            string y = "The value of B is wrong";
            string sum = "we cannot find the sum";
            System.Console.WriteLine(c);
            // nesting the tenary operator
            System.Console.WriteLine(a == 5 ? "we are good to go!!": x);
            System.Console.WriteLine(a == 5 ? b == 0 ? " The values of a and b are :a = " + a + " b = " + b : "The values are not true" : "one of the two values is not true");
            System.Console.WriteLine(a == 8 ? (b == 9 ? "this is the value of b" : y) : x);
            System.Console.WriteLine(a == 8 ? b == 9 ? c.ToString() : sum : "either the value of a or the value of b is wrong");
            //logical representation
            if (a == 8)
            {
                System.Console.WriteLine("We are good to go!!! /n  lets try out something new");
            }
            else
            {
                System.Console.WriteLine(x);
            }
            if (a == 0 && b == 9)
            {
                System.Console.WriteLine("We are good to go");
            }

            else
            {
                System.Console.WriteLine("we failed");
            }
            // interpolation string 
            // we use $ special character
            // used when we have intepolated expression
            //example.. consider a literal string name
            //DateTime parsing
            //var datestring = DateTime.ParseExact(date, "yyyy-mm-dd", null);
            //System.Console.WriteLine(datestring);
            var date = DateTime.Now;
            System.Console.WriteLine($"Hello dear {name}, today is on {date.DayOfWeek} and it is {date:HH:mm} now");
            System.Console.WriteLine("hello dear " + name + " we are in the month of " + date.Month + " and today is on " + date);
            // conditional operators
            int score = 40;
            {
                if (score >= 50) // If score is greater or equal to 50
                {
                    Console.WriteLine("Pass!");
                }
                else // If score is not greater or equal to 50
                {
                    Console.WriteLine("Fail!");
                }
            }

            var datestring = "24-09-2018";
            var thisDate = DateTime.ParseExact(datestring, "dd-MM-yyyy", null);
            System.Console.WriteLine("today is " + thisDate);

            var minutesMonths = DateTime.ParseExact("24-10-2018 09:15:20", "dd-MM-yyyy hh:mm:ss",null);
            System.Console.WriteLine(minutesMonths);
            
            //try parse
            // its a method that accepts string as an input and trys to parse/convert it into a DateTime.
            DateTime parsedValue;

            if(DateTime.TryParse("monkey", out parsedValue))
            {
                System.Console.WriteLine("Apparently, 'monkey' is a date/time value. Who knew?");
            }
            else
            {
                System.Console.WriteLine("a monkey cant be a date/time value");
            }

            bool results = DateTime.TryParse("24-09-2018",out parsedValue);
            System.Console.WriteLine(results);



            //immutable strings
            string longstring = "My name is Wangui Jemmimah";
            string newstring = longstring.Remove(0,11);
            System.Console.WriteLine(newstring);

            //null coalescing operator.
            // allows to specify a nullable value if the left hand side is null
            // since the lhs is null, the specified value in the rhs of ?? will be outputed.

            string teststring = null;
            System.Console.WriteLine("The specified string is " + (teststring ?? "Not valid"));

            // suppose the LHS is not nul...

            string testingString = " a valid and not null";
            string newtest = testingString.Remove(0, 3);
            System.Console.WriteLine("The specified and edited string is " + (newtest ?? "not found"));

            // multiple coalescing
            int? m = null;
            int? w = null;
            int D = 3;
            var output = m ?? w ?? D;
            var type = output.GetType();
            System.Console.WriteLine($"System type {type}");
            System.Console.WriteLine("The Output will be.. "+output);
            // where filter in linq
            var personNames = new[] { "June", "Justin", "Julius", "Jemmy", "Rose", "mike" };
            var namesEndingWithE = personNames.Where(p=> p.EndsWith("j"));
            System.Console.WriteLine(string.Join(",", namesEndingWithE));

            var nameStartingWithj = personNames.Where(p => p.StartsWith("J"));
            System.Console.WriteLine(string.Join("",nameStartingWithj) );

            var nameIsJemmy = personNames.Where(p => p.StartsWith("J"));
            var namenotJemmy = nameIsJemmy.Where(p => p.Contains("u"));
            System.Console.WriteLine(string.Join(",", namenotJemmy));

            var nameExceptJemmy = new[] { "Jemmy", "June" };
            var result = personNames.Except(nameExceptJemmy);
            System.Console.WriteLine(string.Join(",", result));
            // any filter in linq
            var number = new[] { -1, 0, 1, 2, 3, 4, 5 };
            var IsNotEmpty = number.Any();
            System.Console.WriteLine(IsNotEmpty);

            var AnyNumberIsOne = number.Any(n => n == 1);
            System.Console.WriteLine(AnyNumberIsOne);

            var valueNegative = number.Any(n => n <= 0);
            System.Console.WriteLine(valueNegative);

            var oddNumbers = number.Any(n => (n & 2) >=2 );
            System.Console.WriteLine(oddNumbers);

            var whereOdd = number.Where(n => (n + 1) == 1);
            System.Console.WriteLine(string.Join("", whereOdd));

            var inBetween = number.Where(n => (n > 1 && n <= 4));
            System.Console.WriteLine(string.Join("", inBetween));

           

            // to ensure that the console window does not disappear/close immediately after posting the data/ before the user read the content
            System.Console.ReadKey();

            

        }
    }
    
}
     