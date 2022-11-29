using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    //Inherited Class
    class Employee : Person, IQuittable//Inheriting Interface
    {
        public override void SayName()
        {
            Console.WriteLine("Hello!");
            base.SayName();
        }

        public void Quit(string x)
        {
            Console.WriteLine("Bye!");
        }
    }
}
