using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo
{
    class ReThrowingAnException
    {
        public void Method()
        {
            try
            {
                int x = 0;
                int sum = 100 / x;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
        }
    }
}
