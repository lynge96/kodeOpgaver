using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._04
{
    public class TierDeck_of_cards : Deck_of_cards
    {
        // Variabel
        private Stack<Card> deck = new Stack<Card>();

        // Constructor
        public TierDeck_of_cards() : base()
        {
            for (int i = 0; i < 7; i++)
            {
                deck.Push(getCard());
            }
            foreach (Card kort in deck)
            {
                Console.WriteLine(kort);
            }
        }
    }
}
