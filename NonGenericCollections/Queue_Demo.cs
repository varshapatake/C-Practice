using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class Queue_Demo
    {
        public void queue_demo()
        {
            Queue q = new Queue();
            q.Enqueue(1);
            q.Enqueue("sayali");
            q.Enqueue(true);

            foreach(var val in q)
            {
                Console.WriteLine(val);
            }

            q.Dequeue();
            Console.WriteLine();

            foreach (var val in q)
            {
                Console.WriteLine(val);
            }


        }
    }
}
