using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace opg6._03
{
    public class Dice
    {
        // a private variable (member) to hold the current number of eyes
        private Int32 _eyes;
        // initiate a Random-object
        Random rand = new Random();
        public Dice()
        {
            // the constructor initiates the object with a value
            // in _eyes, as a die cannot show no eyes ;-)
            Throw();
        }
        public void Throw()
        {
            // The Next-method of a Random-object returns a random number >= first 
            // parameter and<second parameter
            // (we call the method with the values 1 and 7, i.e. the return value will 
            // be within the range 1 to 6
            _eyes = rand.Next(1, 7);
        }
        public Int32 show()
        {
            // returnes the value of the private variable _eyes
            return _eyes;
        }
    }
}