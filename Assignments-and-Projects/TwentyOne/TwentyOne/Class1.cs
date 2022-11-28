using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card
    {
        //Constructor for default values
        public Card()
        {
            Suit = "Spades";
            Face = "Two";              
        }
        //Public Properties that you can get or set
        public string Suit { get; set; }
        public string Face { get; set; }
    }
}
