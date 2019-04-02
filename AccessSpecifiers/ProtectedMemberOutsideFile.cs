using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessSpecifiers
{
    class ProtectedMemberOutsideFile:Access_Specifiers
    {
        public void show()
        {
            Console.WriteLine(num3);
        }
    }
}
