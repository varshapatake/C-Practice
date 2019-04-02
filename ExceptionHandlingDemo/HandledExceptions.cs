using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class HandledExceptions
    {
        public static void exception_demo()
        {
            int x = 0;
            int div = 0;
            try
            {
                div = 100 / x;
                Console.WriteLine("This linein not executed");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception occured");
            }
            Console.WriteLine($"Result is {div}");
        }
    }
}
