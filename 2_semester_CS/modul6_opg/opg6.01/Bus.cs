using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._01
{
    public class Bus : Vehicle
    {
        // Variabel
        private int noOfPassengers;
        // Property
        public int Passengers
        {
            get { return noOfPassengers; }
            set { noOfPassengers = value; }
        }
        // Constructor
        public Bus(string r, string c, Int32 y, string make, string model, int passengers) : base(r, c, y, make, model)
        {
            this.noOfPassengers = passengers;
        }

    }
}
