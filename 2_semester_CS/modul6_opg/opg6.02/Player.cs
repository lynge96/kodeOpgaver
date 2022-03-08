using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._02
{
    public class Player
    {
        // Variabler
        private String navn;
        private int point;

        // Properties
        public String SpillerNavn
        {
            get { return navn; }
            set { navn = value; }
        }
        public int PointSum
        {
            get { return point; }
            set { point = value; }
        }
        
        // Constructor
        public Player(String navn, int point)
        {
            this.navn = navn;
            this.point = point;
        }
    }
}
