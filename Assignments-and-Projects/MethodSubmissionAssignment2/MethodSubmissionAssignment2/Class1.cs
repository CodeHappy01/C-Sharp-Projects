using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Class1
    {
        //Method (take two parameters)
        public int MyMethod(string x, string y = "0")
        {
            int result = Int32.Parse(x) + 123 + Int32.Parse(y);
            return result;
        }
    }
}
