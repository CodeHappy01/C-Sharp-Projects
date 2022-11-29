using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee = new Employee();

            employee.FirstName = "Sample ";
            employee.LastName = "Student";
            //Superclass Method
            employee.SayName();

            Console.ReadLine();
        }
    }
}
