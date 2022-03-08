using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._01
{
    public class Truck : Vehicle
    {
        // Variabler
        private int maxLoad;
        private int totalWeight;

        // Properties
        public int maxBelastning
        {
            get { return maxLoad; }
        }
        public int totalVægt
        {
            get { return totalWeight; }
        }

        // Constructor
        public Truck(string r, string c, Int32 y, string make, string model, int load, int vægt) : base(r, c, y, make, model)
        {
            this.maxLoad = load;
            this.totalWeight = vægt;
        }

        // Metoder
        public int getMaxLoad()
        {
            return maxLoad;
        }
        public int getTotalWeight()
        {
            return totalWeight;
        }


    }
}
