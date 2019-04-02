using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class CaughtAllException
    {
        public static void exception()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch
            {
                Console.WriteLine("oException");
            }
            Console.WriteLine($"Result is {div}");
        }

        public static void exception2()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("Not executed line");
            }
            catch (Exception)
            {
                Console.WriteLine("oException");
            }
            Console.WriteLine($"Result is {div}");
        }
    }
}
