using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    class Program
    {
        class Demo
        {
            public void sum(out int x,out int y)
            {
                //it is complsary to assing values to out parameters
               // int sum = x + y;   error-use of unassign out parameter
                x = 10;
                y = 20;
            }

            public void add(ref int x,ref int y,ref int sum)
            {
                sum = x + y;
                Console.WriteLine("x "+x+"y "+y+"sum "+sum);
            }
        }
        static void Main(string[] args)
        {
            int x = 56, y = 45,sum=0;

            Demo d = new Demo();
            // d.sum(out x, out y);

            d.add(ref x,ref y, ref sum);
            Console.WriteLine("outside method ");
            Console.WriteLine("x "+x+"y "+y+"sum "+sum);
        }
    }
}
