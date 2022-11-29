using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjectsAssignment
{
    public class Person
    {
        //Public Properties that you can get or set
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void SayName()
        {
            string fullName = FirstName + LastName;
            Console.WriteLine("Name: " + fullName);
        }
    }
}
