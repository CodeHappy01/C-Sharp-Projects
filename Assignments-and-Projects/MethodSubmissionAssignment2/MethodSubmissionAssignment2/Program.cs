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
            Console.WriteLine("Would you like to add another number? (yes/no)");
            string userAnswer = Console.ReadLine();
            int otherNumber = 123;

            if (userAnswer == "yes")
            {
                ////Sends two arguments to MyMethod
                Console.WriteLine("Type another whole number:");
                string userInput2 = Console.ReadLine();
                string userOutput = Class1.MyMethod(userInput1, userInput2);
                Console.WriteLine(userInput1 + " + " + otherNumber + " + " + userInput2 + " = " + userOutput);
            }

            else if (userAnswer == "no")
            {
                //Only sends one argument to MyMethod
                string userOutput = Class1.MyMethod(userInput1);
                Console.WriteLine(userInput1 + " + " + otherNumber + " = " + userOutput);
            }

            else
            {
                Console.WriteLine("Sorry, wrong input");
            }
            Console.ReadLine();
        }
    }
}
