using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Method 1
            Class1 class1 = new Class1();
            Console.WriteLine("Enter whole number:");
            int userInput = Convert.ToInt32(Console.ReadLine());
            class1.MyMethod1(userInput);

            /* local variable definition */
            int a, b;

            /* calling a function to get the values */
            class1.getValues(out a, out b);

            Console.WriteLine("After method call, value of a : {0}", a);
            Console.WriteLine("After method call, value of b : {0}", b);

            //Overload method example
            Console.WriteLine("Enter 2 whole numbers:");
            int userInput2 = Convert.ToInt32(Console.ReadLine());
            int userInput3 = Convert.ToInt32(Console.ReadLine());
            class1.MyMethod1(userInput2, userInput3);

            //Accessing Static Members
            var result = Calculator.Sum(10, 25); // calling static method
            Calculator.Store(result);

            var calcType = Calculator.Type; // accessing static variable
            Calculator.Type = "Scientific"; // assign value to static variable


            Console.ReadLine();
        }
    }
}
