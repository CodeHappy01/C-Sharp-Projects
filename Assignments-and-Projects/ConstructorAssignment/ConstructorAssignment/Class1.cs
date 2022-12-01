using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Class1
    {
        //Constructor 1
        //": this" references constructors and allows you to chain them
        public Class1(string name) : this(name, 100)
        {
        }
        //Constructor 2 (overloading)
        public Class1(string name, int favoriteNumber)
        {
            Number = favoriteNumber;
            Name = name;
        }
        //Properties
        public int Number { get; set; }
        public string Name { get; set; }
    }
}
