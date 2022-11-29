using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Class1
    {
        //Method (take one parameter)
        public static string MyMethod(string x)
        {
            int result = Int32.Parse(x) + Int32.Parse("123");
            return result.ToString();
        }

        //Method (take two parameters)
        public static string MyMethod(string x, string y = "0")
        {
            int result = Int32.Parse(x) + Int32.Parse("123") + Int32.Parse(y);
            return result.ToString();
        }
    }
}
