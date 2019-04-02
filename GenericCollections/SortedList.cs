using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class SortedList
    {
        public void sortedlist_demo()
        {
            SortedList<int, string> s_list = new SortedList<int, string>();
            s_list.Add(2, "varsha");
            s_list.Add(1, "monika");
            s_list.Add(7, "sayali");

            foreach(var val in s_list.Keys)
            {
                Console.WriteLine(val);
            }
        }
    }
}
