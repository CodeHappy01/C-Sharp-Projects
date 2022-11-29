using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated class
            Class1 Class1 = new Class1();
            //First Method Variable
            int multMethod = Class1.MyMethod(123);
            //Second Method Variable
            double subMethod = Class1.MyMethod(y: 55);
            //Third Method Varible
            int addMethod = Class1.MyMethod("321");

            Console.WriteLine(multMethod);
            Console.WriteLine(subMethod);
            Console.WriteLine(addMethod);
            Console.ReadLine();
        } 
    }
}
