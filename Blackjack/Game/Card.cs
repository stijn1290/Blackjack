using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Card
    {
       public enum FaceValues
        {
            aas = 1,
            twee,
            drie,
            vier,
            vijf,
            zes,
            zeven, 
            acht,
            negen,
            tien,
            boer,
            vrouw,
            koning,
        }
        public enum Suits
        {
            harten,
            schoppen,
            klaveren,
            ruiten
        }
        private Suits suit; private FaceValues facevalue; private int value;
        public Card(Card.Suits suit, Card.FaceValues facevalue, int value)
        {
            this.suit = suit;
            this.facevalue = facevalue;
            this.value = value;
        }
        public string toString()
        {
            return $"{this.suit} {this.facevalue}";
        }
        public int getValue()
        {
            return value;
        }
    }
}
