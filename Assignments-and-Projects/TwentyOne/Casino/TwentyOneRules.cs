using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneRules
    {
        //Set to Private just in case someone else wants to use
        //that same name, it will cause conflict
        //static means that the method belongs to the Program class and not an object of the Program class.
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            //Creating Dictionary over Enum as 
            //duplicates in Enum can create conflict
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            //Checks players hand to see if they have any aces
            int aceCount = Hand.Count(x => x.Face == Face.Ace);
            //Result Array for adding each Ace found in players hand
            int[] result = new int[aceCount + 1];
            //Checks _cardValues Dictionary key and sums it
            int value = Hand.Sum(x => _cardValues[x.Face]);
            result[0] = value;
            //if only one Ace is found return result (Face value as 1)
            if (result.Length == 1) return result;
            //if i = 1(result.Length), then it = 1
            //but if i is < result.Length(such as 2 or 3)
            //then * 10
            for (int i = 1; i < result.Length; i++)
            {
                value += (i * 10);
                result[i] = value;
            }
            return result;
        }
        
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleValues = GetAllPossibleHandValues(Hand);
            int value = possibleValues.Max();
            if (value == 21) return true;
            else return false;
        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if (value > 21) return true;
            else return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            //Gets max value from player/dealer result list
            //less than 22
            int playerScore = playerResults.Where(x => x < 22).Max();
            int dealerScore = dealerResults.Where(x => x < 22).Max();
            //Compares player and dealer scores
            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }
    }
}
