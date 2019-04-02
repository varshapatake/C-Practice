using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
    static class Demo
    {
       public static int a = 10,b=56;

      internal static void sum()
        {
            Console.WriteLine(a+b);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo.sum();
            Demo.a = 45;
        }
    }
}
