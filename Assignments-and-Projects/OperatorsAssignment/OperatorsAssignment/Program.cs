using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Two Employee objects
            Employee employee = new Employee();
            Employee employee1 = new Employee();
            //Employee ID numbers
            employee.ID = 123;
            employee1.ID = 123;
            //Checks if ID's are the same or not
            Console.WriteLine("Employee ID's are the same: " + (employee == employee1));
            Console.ReadLine();
        }
    }
}
