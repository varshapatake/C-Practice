using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GenericCollections
{
    class Dictonary
    {
        public void dictionary_demo()
        {
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add("12", "kavita");
            dic.Add("14", null);
            dic.Add("13", "divaya");
            dic.Add("15", "aradhya");

            foreach(var obj in dic.Keys)
            {
                Console.WriteLine(obj);
            }

            foreach(var value in dic.Values)
            {
                Console.WriteLine(value);
            }

        }
    }
}
