using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    abstract class Demo
    {   
        internal Demo()
        {
            Console.WriteLine("absract class constructor");
        }
       abstract public void display1();
       internal void display()
        {
            Console.WriteLine("inside abstract class");
        }
    }

    class Derived : Demo
    {     
        public override void display1()
        {
            Console.WriteLine("inside derived class");
        }     
        public void show()
        {
            Derived d = new Derived();     
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Derived d = new Derived();
            d.display();
            d.display1(); 
        }
    }
}
