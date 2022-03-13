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
        private Deck_of_cards deck;

        // Property
        public Deck_of_cards PlayerDeck
        {
            get { return deck; }
        }
        // Constructor
        public TierPlayer(String navn, int point, Deck_of_cards deck) : base(navn, point)
        {
            this.deck = deck;
        }

    }
}
