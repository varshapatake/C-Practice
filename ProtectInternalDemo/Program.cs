using AccessSpecifiers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectInternalDemo
{
   public class Demo_access_Specifier
    {
        public int num1 = 567;

        private int num2 = 67;

        protected int num3 = 567;

        internal int num4 = 678;

        protected internal int num5 = 567;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Demo_access_Specifier abc = new Demo_access_Specifier();
            Console.WriteLine(abc.num1);
            Console.WriteLine(abc.num4);
            Console.WriteLine(abc.num5);
        }
    }
}
