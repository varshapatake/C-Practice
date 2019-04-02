using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAndTimeSpan
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d=new DateTime();
            Console.WriteLine(d.Day.ToString());
            Console.WriteLine(d.Date.ToString());
            Console.WriteLine(DateTime.Now);

            Console.WriteLine();
            TimeSpan t = new TimeSpan(12,34,45);
            Console.WriteLine(t.TotalHours);
        }
    }
}
