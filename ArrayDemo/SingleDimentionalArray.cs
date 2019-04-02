using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    class SingleDimentionalArray
    {
        public void s_d_demo()
        {
            int[] arr = new int[] { 1, 2, 3, 4 };


            int[] arr1 ={ 1, 2, 3, 4, 5 };

            int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };

            int[] arr4;
            arr4 = new int[6] { 1, 2, 3, 4, 5, 6 };

            int[] arr5 = new int[5];
            arr5[0] = 1;
            arr5[1] = 2;
            arr5[2] = 3;
            arr5[3] = 4;
            arr5[4] = 5;
           
            foreach(var val in arr5)
            {
                Console.WriteLine(val);
            }
            Console.WriteLine();

            for(int i=0;i<arr5.Length;i++)
            {
                Console.WriteLine(arr5[i]);
            }
        }
    }
}
