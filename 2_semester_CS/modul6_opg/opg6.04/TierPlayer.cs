using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace opg6._04
{
    public class TierPlayer : Player
    {
        // Variabel
        private TierDeck_of_cards deck;

        // Property
        public TierDeck_of_cards PlayerDeck
        {
            get { return deck; }
        }

        // Constructor
        public TierPlayer(String player, int point, TierDeck_of_cards deck) : base(player, point)
        {
            this.deck = deck;
        }

    }
}
