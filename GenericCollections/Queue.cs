using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Queue
    {
        public void queue_demo()
        {
            Queue<string> que = new Queue<string>();
            que.Enqueue("rakhi");
            que.Enqueue("pavitra");
            que.Enqueue("shree");
            que.Enqueue("surbhi");

            foreach(var val in que)
            {
                Console.WriteLine(val);
            }

            que.Dequeue();
            Console.WriteLine();
            Console.WriteLine();
            foreach (var val in que)
            {
                Console.WriteLine(val);
            }

        }
    }
}
