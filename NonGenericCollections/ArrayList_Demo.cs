using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class ArrayList_Demo
    {
        public void arralist_demo()
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("abcd");
            list.Add(true);

            foreach (var val in list)
            {
                Console.WriteLine(val);
            }
        }
    }
}
