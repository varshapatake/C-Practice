using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class ThrowingException
    {
        public static void exception()
        {
            try
            {
                throw new DivideByZeroException("Invalid Division");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Exception");
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
