using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethodsSubmissioAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //try catch for user input
            try
            {
                Console.WriteLine("Type a random whole number to be \n" +
                    "multiplied, added, and subtracted " +
                    "separately by 123:");
                //user input
                int userInput = Convert.ToInt32(Console.ReadLine());
                int otherNumber = 123;

                //Returns values from class methods
                int multOutput = Program1.MyMethod1(userInput);
                int addOutput = Program1.MyMethod2(userInput);
                int subOutput = Program1.MyMethod3(userInput);

                //Output of values
                Console.WriteLine( userInput + " * " + otherNumber + " = " + multOutput);
                Console.WriteLine(userInput + " + " + otherNumber + " = " + addOutput);
                Console.WriteLine(userInput + " - " + otherNumber + " = " + subOutput);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please don't divide by zero.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
    
    }

