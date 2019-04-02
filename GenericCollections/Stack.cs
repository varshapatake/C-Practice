using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Stack
    {
        public void stack_Demo()
        {
            Stack<string> stk = new Stack<string>();
            stk.Push("ashvini");
            stk.Push("samya");
            stk.Push("shital");
            stk.Push("neha");

            foreach(var val in stk)
            {
                Console.WriteLine(val);
            }

            stk.Pop();
            Console.WriteLine();
            Console.WriteLine();

            foreach (var val in stk)
            {
                Console.WriteLine(val);
            }
        }
    }
}
