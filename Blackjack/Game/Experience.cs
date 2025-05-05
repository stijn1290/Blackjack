using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blackjack.Game
{
    class Experience
    {
        private int dealerPoints = 0;
        public int getDealerPoints()
        {
            return this.dealerPoints;
        }
        public void setDealerPoints(int newPoints, bool minus)
        {
            if (minus)
            {
                dealerPoints = dealerPoints - newPoints;
            }
            else
            {
                dealerPoints = dealerPoints + newPoints;
            }
        }
    }
}
