using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace opg6._04
{
    public class Deck_of_cards
    {
        // Deklarerer variablerne:
        private Stack<Card> _cards = new Stack<Card>();

        // Laver en constructor:
        public Deck_of_cards()
        {
            string[] suit = { "Hjerter", "Ruder", "Spar", "Klør" };
            for (int i = 0; i < suit.Length; i++)
            {
                for (Int16 j = 1; j <= 9; j++)
                {
                    _cards.Push(new Card(suit[i], j));
                }
            }
            //shuffle();
            foreach (Card kort in _cards)
            {
                Console.WriteLine(kort);
            }
        }
        // Metode til getCard():
        public Card getCard()
        {
            return _cards.Pop();
        }
        // Metode til shuffle
        public void shuffle()
        {
            Card[] array = _cards.ToArray();
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                int rng = rand.Next(0, array.Length);
                Card tal1 = array[i];
                Card tal2 = array[rng];

                array[i] = tal2;
                array[rng] = tal1;
            }
            Stack<Card> stack = new Stack<Card>(array);
            _cards = stack;
        }

    }
}
