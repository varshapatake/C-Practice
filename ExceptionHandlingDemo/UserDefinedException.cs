using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class MyException : Exception
    {
        public MyException(string message):base(message)
        {
        }
    }
    class UserDefinedException
    {
       
        public static void except()
        {
            try
            {
                throw new MyException("userdefine exception");
            }
            catch (MyException e)
            {
                Console.WriteLine("Exception caught here: " + e.Message.ToString());
            }
            Console.WriteLine("LAST STATEMENT");
        }
    }
}
