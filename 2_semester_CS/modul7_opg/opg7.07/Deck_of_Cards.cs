using System;
using System.Collections.Generic;

namespace _7._07
{
    public class Deck_of_Cards
    {
        // Deklarere og initiere variabel 
        private Stack<Card> _cards = new Stack<Card>();

        // Constructor 
        public Deck_of_Cards()
        {
            string[] suit = { "Hjerter", "Ruder", "Klør", "Spar" };

            for (int i = 0; i < 4; i++)
            {
                for (Int16 j = 2; j < 15; j++)
                {
                    _cards.Push(new Card(suit[i], j));
                }

            }

            shuffle();

        }



        // Metode til getCard

        public Card getCard()
        {
            return _cards.Pop();
        }

        public void addCard(Card kort)
        {
            _cards.Push(kort);

            shuffle();
        }

 
       

       
        // Metode til shuffle
        public void shuffle()
        {
            Card[] array = _cards.ToArray();
            Random rand = new Random();

            for (int a = 0; a < array.Length; a++)
            {
                int next = rand.Next(0, array.Length);
                Card tal1 = array[a];
                Card tal2 = array[next];

                array[a] = tal2;
                array[next] = tal1;
            }

            Stack<Card> stack = new Stack<Card>(array);

            _cards = stack;

        }

        

        
    }
}
