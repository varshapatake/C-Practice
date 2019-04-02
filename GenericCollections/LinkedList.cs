using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class LinkedList
    {
        public void LinkedList_demo()
        {
            LinkedList<string> l = new LinkedList<string>();
            l.AddFirst("varsha");
            l.AddFirst("shital");

            foreach(var val in l)
            {
                Console.WriteLine(val);
            }
            l.Remove("shital");

            foreach (var val in l)
            {
                Console.WriteLine(val);
            }
        }
    }
}
