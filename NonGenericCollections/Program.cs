using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList_Demo ald = new ArrayList_Demo();
             ald.arralist_demo();

            Console.WriteLine();
            Console.WriteLine();

            HashTable_Demo h = new HashTable_Demo();
            h.hashTable_demo();

            Console.WriteLine();
            Console.WriteLine();

            Queue_Demo d = new Queue_Demo();
            d.queue_demo();

            Console.WriteLine();
            Console.WriteLine();

            Stack_Demo sd = new Stack_Demo();
            sd.stack_demo();

        }
    }
}
