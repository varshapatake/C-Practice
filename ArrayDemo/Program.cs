using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            SingleDimentionalArray ad_arr = new SingleDimentionalArray();
            ad_arr.s_d_demo();

            MultiDimentionalArray m = new MultiDimentionalArray();
            m.multi_demo();

            Console.WriteLine();
            JaggedArray j = new JaggedArray();
            j.jagged_array_demo();
        }
    }
}
