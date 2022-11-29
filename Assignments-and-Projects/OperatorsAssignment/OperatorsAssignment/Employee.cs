using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }
        //== Operator
        public static bool operator== (Employee employee, Employee employee1)
        {
            //Return True if ID's are the same
            return (employee.ID == employee1.ID);
        }
        //!= Operator
        public static bool operator!= (Employee employee, Employee employee1)
        {
            //Return false if ID's are NOT the same
            return (employee.ID != employee1.ID);
        }
    }
}
