using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Deck
    {
        private List<Card> deck = new List<Card>();
        public Deck()
        {
            int suit = 0; int facevalue = 0;
            for (int i = 1; i < 52; i++)
            {
                suit++; facevalue++;
                Card card = new Card((Card.Suits)suit, (Card.FaceValues)facevalue, (int)(Card.FaceValues)facevalue);
                deck.Add(card);
                if(facevalue == 13)
                {
                    facevalue = 0;
                }
                if(suit == 3)
                {
                    suit = 0;
                }
            }
        }
        public void shuffleDeck()
        {
            Random rnd = new Random();
            deck = deck.OrderBy(_ => rnd.Next()).ToList();
        }
        public Card pullCard()
        {
            Card kaart = deck.First();
            deck.Remove(kaart);
            return kaart;
        }
    }
}
