using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Abstact Class
    public abstract class Person
    {
        //properties
        public string firstName { get; set; }
        public string lastName { get; set; }

        //virtual Method
        public virtual void SayName()
        {
            string fullName = firstName + lastName;
            Console.WriteLine("Name: " + fullName);
        }
    }
}
