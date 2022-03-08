using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace opg6._02
{
    public class KrigPlayer : Player
    {
        // Variabel
        private Deck_of_cards deck;

        // Property
        public Deck_of_cards PlayerDeck
        {
            get { return deck; }
        }
        // Constructor
        public KrigPlayer(String navn, int point, Deck_of_cards deck) : base(navn, point)
        {
            this.deck = deck;
        }

    }
}
