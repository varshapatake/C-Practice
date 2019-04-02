using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonGenericCollections
{
    class Stack_Demo
    {
        public void stack_demo()
        {
            Stack s = new Stack();
            s.Push(1);
            s.Push("varsha");
            s.Push(true);

            foreach(var val in s)
            {
                Console.WriteLine(val);
            }
            s.Pop();
            Console.WriteLine();

            foreach (var val in s)
            {
                Console.WriteLine(val);
            }
        }
    }
}
