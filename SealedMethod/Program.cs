using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedMethod
{
    class Base
    {
        public virtual void display()
        {
            Console.WriteLine("inside base method");
        }
    }
    class Derived:Base
    {
        public override void display()
        {
            Console.WriteLine("inside derived class");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           // Base b = new Base();
            //b.display();

            Derived d = new Derived();
            d.display();
        }
    }
}
