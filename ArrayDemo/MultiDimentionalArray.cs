using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class MultiDimentionalArray
    {
        public void multi_demo()
        {
            int[,] arr = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
           for(int i=0;i<arr.GetLength(0);i++)
            {
                for(int j=0;j<arr.GetLength(1);j++)
                {
                    Console.Write(arr[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(arr.GetLength(0));
            Console.WriteLine(arr.GetLength(1));
        }
    }
}
