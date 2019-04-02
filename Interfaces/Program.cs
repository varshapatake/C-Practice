using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface Loan
    {
        void loan();
    }
    interface Bank
    {
        void depsite();
        void withdraw();
        void rate_of_interest();
    }

    public class SBI : Bank, Loan
    {
        public void depsite()
        {
            Console.WriteLine("SBI deposite");
        }

        public void rate_of_interest()
        {
            Console.WriteLine("SBI rate_of_interest");
        }

        public void withdraw()
        {
            Console.WriteLine("SBI withdraw");
        }
        public void loan()
        {
            Console.WriteLine("SBI loan");
        }
    }

    public class AXIs : Bank, Loan
    {
        public void depsite()
        {
            Console.WriteLine("AXIS bank deposite");
        }

        public void loan()
        {
            Console.WriteLine("AXIS bank loan");
        }

        public void rate_of_interest()
        {
            Console.WriteLine("AXIS bank rate_of_interest");
        }

        public void withdraw()
        {
            Console.WriteLine("AXIs bank withdraw");
        }
    }


    //exlpicit interface
    interface Box
    {
        void draw();
    }
    interface Circle
    {
        void draw();
    }

    class Paint : Box, Circle
    {
        //can't use public access specifier here
       void Box.draw()
        {
            Console.WriteLine("Box.draw");
        }
        void Circle.draw()
        {
            Console.WriteLine("Circle.draw");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            SBI s = new SBI();
            s.depsite();
            s.rate_of_interest();
            s.withdraw();
            s.loan();

            AXIs a = new AXIs();
            a.depsite();
            a.rate_of_interest();
            a.withdraw();
            a.loan();

            Paint p = new Paint();
            Box b = p;
            b.draw();

            Circle c = p;
            c.draw();
        }
    }
}
