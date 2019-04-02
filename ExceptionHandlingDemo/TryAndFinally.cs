using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class TryAndFinally
    {
        //will not provide any output because of uncauaght exception
        public static void exception_demo()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            finally
            {
                Console.WriteLine("Finally Block");
            }
            Console.WriteLine($"Result is {div}");
        }
    }
}
