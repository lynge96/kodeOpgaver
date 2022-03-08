using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg6._01
{
    public class Car : Vehicle
    {
        // Variabler
        private int noOfSeats;
        private int noOfDoors;

        // Properties
        public int antalSæder
        {
            get { return noOfSeats; }
            set { noOfSeats = value; }
        }
        public int antalDøre
        {
            get { return noOfDoors; }
        }
        // Constructor
        public Car(string r, string c, Int32 y, string make, string model, int doors, int seats) : base(r, c, y, make, model)
        {
            this.noOfSeats = seats;
            this.noOfDoors = doors;
        }

        // Metoder
        public int getDoors()
        {
            return noOfDoors;
        }

    }
}
