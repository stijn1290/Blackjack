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
            aas = 11,
            twee = 2,
            drie,
            vier,
            vijf,
            zes,
            zeven, 
            acht,
            negen,
            tien,
            boer = 10,
            vrouw = 10,
            koning = 10,
        }
        public enum Suits
        {
            harten,
            schoppen,
            klaveren,
            ruiten
        }
        private Suits suit; private FaceValues facevalue;
        public Card(Card.Suits suit, Card.FaceValues facevalue)
        {
            this.suit = suit;
            this.facevalue = facevalue;
        }
        public string toString()
        {
            return $"{this.suit} {this.facevalue}";
        }
    }
}
