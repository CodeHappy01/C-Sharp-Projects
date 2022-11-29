using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated Class
            Employee employee = new Employee();
            IQuittable quitter = new Employee();
            employee.firstName = "Sample ";
            employee.lastName = "Student";
            //Calling Method SayName()
            employee.SayName();
            //Object for Interface
            quitter.Quit("yes");
            Console.ReadLine();
        }
    }
}
