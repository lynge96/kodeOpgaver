using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._02
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

            if (_rank < 2 || _rank > 14)
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
            if (_rank == 11)
            {
                return _suit + " Knægt";
            }
            else if (_rank == 12)
            {
                return _suit + " Dronning";
            }
            else if (_rank == 13)
            {
                return _suit + " Konge";
            }
            else if (_rank == 14)
            {
                return _suit + " Es";
            }
            return _suit + " " + _rank;
        }
    }
}
