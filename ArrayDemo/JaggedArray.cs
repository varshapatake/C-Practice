using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class JaggedArray
    {
        public void jagged_array_demo()
        {
            int[][] arr = new int[2][] { new int[] { 1,2,3},new int[] { 1, 2, 3 } };
            foreach(var val in arr)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine(arr[0][0]);
            Console.WriteLine(arr[1][2]);
            Console.WriteLine();
        }
    }
}
