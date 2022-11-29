using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Employee
    {
        public List<int> employeeList { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int ID { get; set; }

        public static Employee operator== (Employee employee, Employee employee1)
        {
            employee.employeeList.Add(employee.ID);
            return employee;
        }
        public static Employee operator!= (Employee employee, Employee employee1)
        {
            employee.employeeList.Remove(employee.ID);
            return employee;
        }
    }
}
