using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessSpecifiers;
using ProtectInternalDemo;


namespace  Library1

{
    public class Class1 : Demo_access_Specifier
    {
        void display()
        {
            Demo_access_Specifier demo = new Demo_access_Specifier();
            Console.WriteLine(demo.num1); //public varibles are accessible by base class object (in diff libary project)
                                          // Console.WriteLine(demo.num2);  error-private members are not accessible
                                          // Console.WriteLine(demo.num3);  error-private memeber can not access with base class object
                                          //Console.WriteLine(demo.num4); error-protected members can not be access in another project or assembly
            Console.WriteLine(demo.num5);  error-internal protected Member can not access as ProtectInternalDemo variables can't access ouside of project and we can't access protected variable with base class object
        }
       /* public int i1 = 10;
        protected internal int i2 = 9;
     
        public static void Main()
        {
            Access_Specifiers wspec = new Access_Specifiers();
            Class1 clas = new Class1();
            Console.WriteLine(clas.);
            Console.WriteLine(wspec.);

        }//end main

        /*void show()
        {
            Access_Specifiers asp = new Access_Specifiers();

            Console.WriteLine(asp.);
        }*/
    }
}
