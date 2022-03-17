using System;
namespace _7._07
{
    public class Card
    {
        // Deklarerer variablerne 
        private string _suit;
        private Int16 _rank;

        // Properties 
        public string Suit
        {
            get
            { return _suit; }
        }

        public Int16 Rank
        {
            get
            { return _rank; }
        }

        // Constructor

        public Card(string s, Int16 r)
        {
            _suit = s;
            _rank = r;


            if (s != "Klør" && s!= "Spar" && s!= "Ruder" && s != "Hjerter")
            {
                throw new Exception($"{s} er en ugyldig værdi!");
            }

            if (r < 2 || r > 14)
            {
                throw new Exception($"{r} er en ugyldig værdi!");
            }
           
        }

        // ToString metode

        public override string ToString()
        {
            if (_rank == 11)
            {
                return _suit + " knægt";
            }
            else if (_rank == 12)
            {
                return _suit + " dame";
            } else if (_rank == 13)
            {
                return _suit + " konge";
            } else if (_rank == 14) {
                return _suit + " es";
            } else
            {
                return _suit + " " + _rank;
            }
        }

    }
}
