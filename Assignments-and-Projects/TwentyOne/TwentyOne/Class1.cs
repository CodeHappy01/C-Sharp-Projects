using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    { 
        //Public Properties that you can get or set
        public Suit Suit { get; set; }
        public Face Face { get; set; }
    }
    public enum Suit 
    {
         Clubs ,
         Diamands,
         Hearts,
         Spades
    }
    public enum Face
    {
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King,
        Ace
    }
}
