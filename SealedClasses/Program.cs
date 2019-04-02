using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
    sealed class Demo
    {
       internal void display()
        {
            Console.WriteLine("inside sealed class");
        }
    }
   /* class Derived : Demo   error can not derived from sealed class
    {

    }*/
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo();
            d.display();
        }
    }
}
