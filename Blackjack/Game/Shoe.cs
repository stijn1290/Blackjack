using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Shoe
    {
        private List <Deck> decks = new List<Deck>() ;
        public Shoe()
        {
            for (int i = 1; i < 8; i++)
            {
                Deck deck = new Deck() ;
                decks.Add(deck) ;
            }
        }
        public Deck firstDeck ()
        {
            Deck deck = decks.First() ;
            decks.Remove(deck) ;
            return deck ;
        }
    }
}
