using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today?");
            int bank = Convert.ToInt32(Console.ReadLine());
            //SelfNote:{0} placehodler for varible(varible is at the end of string seperated by comma) 
            Console.WriteLine("Hello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                //Polymorphism
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                //while isActivelyPlaying is true and Balance > 0...
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    //Where the game actually begins
                    game.Play();   
                }
                //End of program (if player says no or anything)(helps skip else statement)
                game -= player;
                Console.WriteLine("Thank you for playing!");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now.");
            Console.ReadLine();
        }
    }
}
