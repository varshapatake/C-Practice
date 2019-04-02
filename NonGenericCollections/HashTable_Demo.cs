using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace NonGenericCollections
{
    class HashTable_Demo
    {
        public void hashTable_demo()
        {
            Hashtable ht = new Hashtable();
            ht.Add(1, "one");
            ht.Add(2, "two");
            ht.Add(3, "three");
            ht.Add("four", 4);

            foreach(DictionaryEntry entry in ht)
            {
                Console.WriteLine("key:{0} value:{1}",entry.Key,entry.Value);
            }

            ht.Remove(1);
            Console.WriteLine();

            foreach (DictionaryEntry entry in ht)
            {
                Console.WriteLine("key:{0} value:{1}", entry.Key, entry.Value);
            }
        }
    }
}
