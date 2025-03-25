using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Player
    {
        private bool dealer;
        private List<Card> cards = new List<Card>();
        public Player(bool dealer)
        {
            this.dealer = dealer;
        }
        public void addCard (Card card)
        {
            cards.Add(card);
        }
        public string getCards()
        {
            if (cards != null && cards.Count > 0) // Check if cards exist and are not empty
            {
                StringBuilder result = new StringBuilder(); // Use StringBuilder for efficiency

                foreach (Card card in cards)
                {
                    result.Append(card.toString()).Append(", "); // Append each card string
                }

                return result.ToString().TrimEnd(',', ' '); // Remove trailing comma and space
            }

            return "The player doesn't have any cards";
        }
    }
}
