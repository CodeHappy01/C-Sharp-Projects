using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Bradley";
            //string quote = "The man said, \\Hello\", Bradley. \n Hello on a new line. \n \t Hello on a tab.";
            //string fileName = @"C: \Users\ Happy";

            //bool trueOrFalse = name.Contains("y");
            //trueOrFalse = name.EndsWith("y");

            //int length = name.Length;

            //name = name.ToUpper();
            //name = name.ToLower();
            //Console.WriteLine(name);
            //Console.ReadLine();

            //string name = "Bradley";
            //name = "Chadley";

            //Console.WriteLine(name);
            //Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Bradley");

            Console.WriteLine(sb);
            Console.ReadLine();


        }
    }
}
