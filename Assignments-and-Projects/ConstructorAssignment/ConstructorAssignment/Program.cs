using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //const varible
            const string userName = "Chadley";
            //var Variable
            var numberValue = "100";

            //Class Object with constructor arguments
            Class1 constructor = new Class1("Dave");
            //Writes values
            Console.WriteLine("Const: {0}\nVar: {1}\nConstructorName: {2}\nConstructorNumber: {1}", 
                userName, numberValue, constructor.Name, constructor.Number);
            Console.ReadLine();


        }
    }
}
