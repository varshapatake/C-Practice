using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void HelloFunctionDelegate(string message);
    class Program
    {
        static void Main(string[] args)
        {
            multicastDelegateDemo.demo();
            Console.WriteLine();
             HelloFunctionDelegate d = new HelloFunctionDelegate(Hello);
             d("this is my first example on delegate");
        }

        public static void Hello(string msg)
        {
            Console.WriteLine(msg);
        }
    }  
}
