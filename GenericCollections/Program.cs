using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
      
            /*Dictonary d = new Dictonary();
            d.dictionary_demo();*/

            /*List l = new List();
            l.list_demo();*/

            /* Queue q = new Queue();
             q.queue_demo();*/

            /*Stack s = new Stack();
            s.stack_Demo();*/

            /*SortedList sl = new SortedList();
            sl.sortedlist_demo();*/

            /* HashSet h = new HashSet();
             h.hashset_demo();
             h.hashset_with_class();*/

            /*LinkedList ll = new LinkedList();
            ll.LinkedList_demo();*/
            static void Main(string[] args)
            {
                int n;
                int value = Calc(out n);
                Console.WriteLine(value);
            }
            static int Calc(out int n)
            {
                int i = 1;
                n = 7;
                for (int j = 1; j <= n; j++)
                {
                    i = i * j;
                }
                return i;
            }

        }
    }

