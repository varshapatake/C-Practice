using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            add(1, 2, 3, 4);
            conacate("abc", "fsdh");
        }

        public static void add(params int[] parameters)
        {
            int sum = 0;
            foreach(var val in parameters)
            {
                sum = sum + val;
            }
            Console.WriteLine(sum);
        }
        public static void conacate(params string[] parameter)
        {
            string value =" ";
            foreach(var val in parameter)
            {
                value = value+" " + val;
            }
            Console.WriteLine(value);
        }
    }
}
