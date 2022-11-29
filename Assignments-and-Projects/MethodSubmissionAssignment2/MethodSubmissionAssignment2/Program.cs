using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 class1 = new Class1();
            Console.WriteLine("Type a whole number:");
            string userInput1 = Console.ReadLine();
            //Asks user whether they want to add second number
            Console.WriteLine("Type another whole number(optional): ");
            string userInput2 = Console.ReadLine();
            int otherNumber = 123;

            if (userInput2 == string.Empty)
            {
                //Only sends one argument to MyMethod
                int userOutput = class1.MyMethod(userInput1);
                Console.WriteLine(userInput1 + " + " + otherNumber + " = " + userOutput);               
            }

            else
            {
                ////Sends two arguments to MyMethod
                int userOutput = class1.MyMethod(userInput1, userInput2);
                Console.WriteLine(userInput1 + " + " + otherNumber + " + " + userInput2 + " = " + userOutput);
            }
            Console.ReadLine();
        }
    }
}
