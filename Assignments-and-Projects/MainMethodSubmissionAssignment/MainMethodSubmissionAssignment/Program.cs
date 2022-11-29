using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethodSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiated class
            Class1 Class1 = new Class1();
            //First Method Variable
            int multMethod = Class1.MyMethod(123);
            //Second Method Variable
            double subMethod = Class1.MyMethod(y: 55);
            //Third Method Varible
            int addMethod = Class1.MyMethod("321");

            Console.WriteLine(multMethod);
            Console.WriteLine(subMethod);
            Console.WriteLine(addMethod);
            Console.ReadLine();





            //{
            //    static void Main(string[] args)
            //    {
            //        Deck deck = new Deck();
            //        int timesShuffled = 0;
            //        deck = Shuffle(deck: deck, out timesShuffled, times: 3);

            //        foreach (Card card in deck.Cards)
            //        {
            //            Console.WriteLine(card.Face + " of " + card.Suit);
            //        }
            //        Console.WriteLine(deck.Cards.Count);
            //        Console.WriteLine("Times shuffled: {0}", timesShuffled);
            //        Console.ReadLine();
            //    }

            //    public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)
            //    {
            //        timesShuffled = 0;
            //        for (int i = 0; i < times; i++)
            //        {
            //            timesShuffled++;
            //            List<Card> TempList = new List<Card>();
            //            Random random = new Random();

            //            while (deck.Cards.Count > 0)
            //            {
            //                int randomIndex = random.Next(0, deck.Cards.Count);
            //                TempList.Add(deck.Cards[randomIndex]);
            //                deck.Cards.RemoveAt(randomIndex);
            //            }
            //            deck.Cards = TempList;
            //        }

            //        return deck;

            //    }
            //public static Deck Shuffle(Deck deck, int times) 
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);   
            //    }
            //    return deck;

            //}


        } 
    }
}
