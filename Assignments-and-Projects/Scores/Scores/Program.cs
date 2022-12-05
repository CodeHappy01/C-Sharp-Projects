using System;

namespace Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter in your first name.");
            string date = DateTime.Today.ToLongDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.Write(msg);

            string path = @"C:\Users\Happy\OneDrive\One Drive\Documents\GitHub\C-Sharp-Projects\Assignments-and-Projects\Scores\Scores\studentScores.txt";
            string[] lines = System.IO.File.ReadAllLines(path);


            double tScore = 0.0;

            Console.WriteLine("\nStudent Scores: \n");
            foreach (string line in lines )
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }

            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotel of " + lines.Length + " student scores. \t Average score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
