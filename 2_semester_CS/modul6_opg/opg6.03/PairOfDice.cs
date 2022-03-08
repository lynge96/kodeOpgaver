using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._03
{
    public class PairOfDice : Dice
    {
        // Variabel
        private Dice terning1;
        private Dice terning2;
        Random rng = new Random();

        // Property
        public Dice Terning1
        {
            get { return terning1; }
        }
        public Dice Terning2
        {
            get { return terning2; }
        }

        // Constructor
        public PairOfDice(Dice førsteTerning, Dice andenTerning) : base()
        {
            this.terning1 = førsteTerning;
            this.terning2 = andenTerning;
        }

        // Metoder
        public void ThrowDices()
        {
            terning1.Throw();
            terning2.Throw();
        }
        public int addedValue()
        {
            return terning1.show() + terning2.show();
        }
    }
}
