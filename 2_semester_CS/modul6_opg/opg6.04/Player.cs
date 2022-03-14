using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._04
{
    public class Player
    {
        // Variabler
        private String player;
        private int point;

        // Properties
        public String PlayerNavn
        {
            get { return player; }
            set { player = value; }
        }
        public int PlayerPoint
        {
            get { return point; }
            set { point = value; }
        }

        // Constructor
        public Player(String navn, int point)
        {
            this.player = navn;
            this.point = point;
        }
    }
}
