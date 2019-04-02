using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureDemo
{
    struct Demo
    {
        public int Emp_id;
        public  string firstname;
        public string lastname;

        static Demo()
        {
            Console.WriteLine("this is an static contructor");
        }
        public Demo(int id,string first,string last)
        {
            Emp_id = id;
            firstname = first;
            lastname = last;
        }
        public void display()
        {
            Console.WriteLine("statement under display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo dm = new Demo(1,"shital","bhatiya");
            dm.display();
          /*  Console.WriteLine(dm.Emp_id);
            Console.WriteLine(dm.firstname);
            Console.WriteLine(dm.lastname);*/

            Console.WriteLine();
            Demo d;
            d.Emp_id = 1;
            d.firstname = "sharad";
            d.lastname = "kale";
            d.display();
            Console.WriteLine();
            Console.WriteLine(d.Emp_id);
            Console.WriteLine(d.firstname);
            Console.WriteLine(d.lastname);
        }
    }
}
