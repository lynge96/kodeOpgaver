using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._04
{
    public class Card
    {
        // Deklarerer variablerne
        private Int16 _rank;
        private string _suit;

        // Laver en constructor
        public Card(string s, Int16 r)
        {
            _suit = s;
            _rank = r;

            if (_rank < 1 || _rank > 9)
            {
                throw new Exception($"{_rank} er en ugyldig værdi");
            }
            if (_suit != "Hjerter" && _suit != "Ruder" && _suit != "Spar" && _suit != "Klør")
            {
                throw new Exception($"{_suit} er en ugyldig værdi!");
            }
        }
        // Rank Property
        public Int16 Rank
        {
            get { return _rank; }

        }
        // Suit Property
        public string Suit
        {
            get { return _suit; }
        }

        public override string ToString()
        {
            if (_rank == 1)
            {
                return _suit + " Es";
            }
            return _suit + " " + _rank;
        }
    }
}
