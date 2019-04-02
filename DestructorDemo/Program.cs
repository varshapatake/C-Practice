using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DestructorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo d = new Demo(23,34);
            d.display();
            d.display();

        }
    }
}
