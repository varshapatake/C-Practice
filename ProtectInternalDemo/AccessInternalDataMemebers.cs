using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtectInternalDemo
{
    class AccessInternalDataMemebers: Demo_access_Specifier
    {
        void show()
        {
            Demo_access_Specifier asp = new Demo_access_Specifier();
            // Console.WriteLine(asp.num3); //protect variable can not access with base class object
            Console.WriteLine("");

            AccessInternalDataMemebers ws = new AccessInternalDataMemebers();
            Console.WriteLine(ws.);
        }
    }
}
