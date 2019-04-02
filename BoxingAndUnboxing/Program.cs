using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            //boxing:implicit conversion of value type into refernce type
            int val = 67;
            Object obj = val;
            Console.WriteLine(obj);
            Console.WriteLine(obj.GetType().ToString());


            //unboxing :explicit conversion of ref type into valaue type
            int ubox_int = (int)obj;
            Console.WriteLine();
            Console.WriteLine(ubox_int);
            Console.WriteLine(ubox_int.GetType().ToString());
        }
    }
}
