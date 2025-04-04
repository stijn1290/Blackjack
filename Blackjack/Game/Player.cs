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
        private int score = 0;
        private bool stand = false;
        public Player(bool dealer)
        {
            this.dealer = dealer;
        }
        public void addCard (Card card)
        {
            int kaarten = cards.Count();
            if(kaarten <= 1)
            {
                cards.Add(card);
            }
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
        public int getAmountOfCards()
        {
            return cards.Count();
        }
        public void setScore(int plusScore)
        {
            score = score + plusScore;
        }
        public int getScore()
        {
            return score;
        }
        public void doubling()
        {
            score *= 2;
        }
        public void setStand(bool value)
        {
            stand = value;
        }
        public void hit()
        {
            Deck deck = new Deck();
            deck.shuffleDeck();
            Card kaart = deck.pullCard();
            cards.Add(kaart);
            score = score + kaart.getValue();
        }
        public string roundSimulation(string player)
        {
            string roundResult = "";
            if (!stand)
            {
                if (score <= 11)
                {
                    hit();
                    setStand(true);
                    roundResult = $"{player} choose hit";
                }
                else if (score <= 17)
                {
                    if (getAmountOfCards() == 2)
                    {
                        doubling();
                        roundResult = $"{player} choose doubling";
                    }
                    else
                    {
                        hit();
                        roundResult = $"{player} choose hit";
                    }
                    setStand(true);
                }
                else
                {
                    setStand(true);
                    roundResult = $"{player} choose stand";
                }
            }
            setStand(false);
            return roundResult;
        }
    }
}
