using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino
{
    public struct Card
    { 
        //Public Properties that you can get or set
        public Suit Suit { get; set; }
        public Face Face { get; set; }

        //Classes have a built in ToString Method so we made a
        //custom ToString method
        public override string ToString()
        {
            return string.Format("{0} of {1}", Face, Suit);   
        }
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
