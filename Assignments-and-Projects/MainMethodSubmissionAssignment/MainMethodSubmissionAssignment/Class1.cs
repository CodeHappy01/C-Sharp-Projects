using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Class1
    {
        //First Method 
        public int MyMethod(int x)
        {
            return x * 321;
        }
        //Second Method
        public int MyMethod(decimal y)
        {
            int input = (int)y;
            return input - 5;
        }
        //Third Method
        public int MyMethod(string z)
        {
            return Int32.Parse(z) + 10;
            
        }
    }
    }
