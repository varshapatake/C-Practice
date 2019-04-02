using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class List
    {
        public void list_demo()
        {
            List<string> lst = new List<string>();
            lst.Add("rani");
            lst.Add("aradhya");
            lst.Add(null);
            lst.Add("trupti");
            lst.Add("ashi");

            foreach(var val in lst)
            {
                Console.WriteLine(val);
            }

            lst.Remove("rani");

            foreach (var val in lst)
            {
                Console.WriteLine(val);
            }
        }
    }
}
