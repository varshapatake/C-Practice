using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
   
    class multicastDelegateDemo
    {
        public delegate void multicastDelDemo();
        public static void demo()
        {
            multicastDelDemo del1, del2, del3,del4;
            del1 = new multicastDelDemo(Method1);
            del2 = new multicastDelDemo(Method2);
            del3 = new multicastDelDemo(Method3);
            del4 = del1 + del2 + del3-del3;
            del4();

            Console.WriteLine();
            multicastDelDemo del5 = new multicastDelDemo(Method1);
            del5 += Method2;
            del5 += Method3;
            del5();
        }
        public static void Method1()
        {
            Console.WriteLine("inside method1");
        }
        public static void Method2()
        {
            Console.WriteLine("inside method2");
        }
        public static void Method3()
        {
            Console.WriteLine("inside method3");
        }
    }
}
