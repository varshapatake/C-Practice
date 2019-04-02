using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleExamples
{
    public class Demo
    {
        public int data;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /* Employee e1 = new Employee("varsha");
             Employee e2 = e1;
             Console.WriteLine(e1.Equals(e2));
             Console.WriteLine(((object)e1).Equals((object)e2));

             Console.WriteLine();
             Demo d = new Demo();
             d.data = 3;
             Demo d1 = new Demo();
             d1 = d;
             d1.data = 5;
             Console.WriteLine(d.data);*/
            List<string> names = new List<string>();
            names.AddRange(new string[] { "Arun", "Kiran", "Meena", "Sachin", "Komal" });
            int ind = names.BinarySearch("Meena");
            Console.Write(ind);
        }
    }
}
