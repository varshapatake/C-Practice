using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class Demo
    {
        int a, b;
        public Demo(int a,int b)
        {
            this.a = a;
            this.b = b;
        }

        public void display()
        {
            Console.WriteLine(a+" "+b);
        }
        ~Demo()
        {
            Console.WriteLine("destructor called");
        }
    }
}
