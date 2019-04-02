using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class UncauaghtException
    {
        public static void exception_demo()
        {
            int x = 0;
            int div = 100 / x;
            Console.WriteLine(div);
        }
    }
}
