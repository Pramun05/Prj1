using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prj1
{
    internal class Calculator
    {
        public int Addition(dynamic a,dynamic b)
        {
            return a + b;
        }

        public int Subtraction(dynamic a,dynamic b)
        {
            if (a < b)
                throw new ArgumentException("a is leass than b");
            return a - b;
              
        }
    }
}
