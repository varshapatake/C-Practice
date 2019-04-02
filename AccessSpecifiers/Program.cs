using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Library1;

namespace AccessSpecifiers
{
    public class Access_Specifiers
    {
        //public data member
        public  int num1 = 12;

        //private data member
        private int num2 = 12;

        //protected data member
        protected int num3 = 12;

        //internal data member
        internal int num4 = 12;

        //protected internal data member
        protected internal int num5 = 12;
    }

    class Derived:Access_Specifiers
    {
        public void display()
        {
            Console.WriteLine(num3);
        }

        public int return_Value(int x)
        {
            x = 23;
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Access_Specifiers asp = new Access_Specifiers();

            //accessing public data members
            //Console.WriteLine(asp.num1);

            //accessing private dta members
            //Console.WriteLine(asp.num2);   error-num2 is inaccessible due to protection level

            //accessing protected data members
            // Console.WriteLine(asp.num3);    error-num3 is inaccessible due to protection level as Program is not derived class of Access_specifier

            //accessing internal data memeber
            //Console.WriteLine(asp.num4);

            //accessing protected internal data member
            //Console.WriteLine(asp.num5);

            Derived d = new Derived();
            //d.display();

            //Class1 c = new Class1();      

            int x = 50;
            Console.WriteLine(d.return_Value(x));
            Console.WriteLine(x);
        }
    }
}
