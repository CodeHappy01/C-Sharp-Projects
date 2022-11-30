using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            //List of employee objects
            List<Employee> employees = new List<Employee>() 
            { new Employee() {ID = 1, firstName = "Bradley", lastName = "Smith"}, 
                new Employee() { ID = 2, firstName = "Joe", lastName = "Smith" },
            new Employee() { ID = 3, firstName = "Joe", lastName = "Smith" },
            new Employee() { ID = 4, firstName = "Doe", lastName = "Smith" },
            new Employee() { ID = 5, firstName = "Brandon", lastName = "Smith" },
            new Employee() { ID = 6, firstName = "Jesse", lastName = "Smith" },
            new Employee() { ID = 7, firstName = "Bill", lastName = "Smith" },
            new Employee() { ID = 8, firstName = "Dave", lastName = "Smith" },
            new Employee() { ID = 9, firstName = "Steve", lastName = "Smith" },
            new Employee() { ID = 10, firstName = "Jill", lastName = "Smith" }};
            List<Employee> joeList = new List<Employee>();

            //foreach loop that goes though employees list and
            //adds any employee with first name "Joe" to joeList 
            foreach (Employee e in employees)
            {
                if (e.firstName == "Joe")
                {
                    joeList.Add(e);
                }
            }

            //Lambda
            //lambda for adding employees with first name joe to new list
            List<Employee> lambdaJoeList = employees.Where(x => x.firstName == "Joe").ToList();
            //lambda for adding employees with ID > 5 to new list
            List<Employee> lambdaIDList = employees.Where(x => x.ID > 5).ToList();

            Console.ReadLine();

        }
    }
}
