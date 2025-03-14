using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Deck
    {
        private List<Array> cards;
        public Deck(List<Card> cards)
        {
            int suit = 0; int facevalue = 0;
            for (int i = 1; i < 52; i++)
            {
                suit++; facevalue++;
                Card card = new Card((Card.Suits)suit, (Card.FaceValues)facevalue);
                cards.Add(card);
                if(facevalue == 13)
                {
                    facevalue = 0;
                }
                if(suit == 4)
                {
                    suit = 0;
                }
            }
        }
    }
}
