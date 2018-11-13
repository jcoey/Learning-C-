using Namespaces.NewNamespace;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Welcome welcome = new Welcome();
            //welcome.WelcomeMessage();
            //Console.ReadKey();
            Welcome.WelcomeMessage();
            Console.ReadKey();
        }
    }
    namespace NewNamespace
    {
        static class Welcome
        {
            public static void WelcomeMessage()
            {
                Console.WriteLine("hello, We are using a static class.");
            }
        }
    }
}
