using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
           // UncauaghtException.exception_demo();
            HandledExceptions.exception_demo();
            Console.WriteLine();

            TryCatchAndFinally.exception();
            Console.WriteLine();

            //TryAndFinally.exception_demo();
            Console.WriteLine();

            MultipleCatch.exception_demo();
            Console.WriteLine();

            CaughtAllException.exception();
            Console.WriteLine();
            CaughtAllException.exception2();
            Console.WriteLine();
            ThrowingException.exception();


            Console.WriteLine();
            ReThrowingAnException r = new ReThrowingAnException();
            try {
                r.Method();
            }
            catch(Exception)
            {
                Console.WriteLine("exception occurs here");
            }
            Console.WriteLine("last statement");


            Console.WriteLine();
            UserDefinedException.except();
        }
    }
}
