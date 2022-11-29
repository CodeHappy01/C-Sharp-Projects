using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Class1
    {
        //Method 1
        public void MyMethod1(int x)
        {
            int result = x / 2;
            Console.WriteLine(x + " / " + "2" + " = " + result);
        }
        //Method for Output Parameters
        public void getValues(out int x, out int y)
        {
            Console.WriteLine("Enter the first value: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second value: ");
            y = Convert.ToInt32(Console.ReadLine());
        }
        //Overload Method
        public void MyMethod1(int x, int y = 0)
        {
            int result = x / y;
            Console.WriteLine(x + " / " + y + " = " + result);
        }
    }
}

