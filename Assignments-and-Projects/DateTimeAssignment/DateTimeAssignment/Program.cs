using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Varible for current time
            DateTime currentTime = DateTime.Now;
            Console.WriteLine(currentTime);
            //Asks user for number
            Console.WriteLine("Type a number: ");
            //Set user answer to int variable
            int userInput = Convert.ToInt32(Console.ReadLine());
            //Adds userInput number to current time as hours
            DateTime userxHoursLater = currentTime.AddHours(userInput);
            Console.WriteLine("{0} hours from now will be {1}",userInput ,userxHoursLater);
            Console.ReadLine();

        }
    }
}
