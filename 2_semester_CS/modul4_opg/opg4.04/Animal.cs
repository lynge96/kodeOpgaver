using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg4._04
{
    public class Animal
    {
        public string _lyd;

        // constructor
        public Animal(string s)
        {
            _lyd = s;
        }
        // Property: sound
        public string sound
        {
            get 
            { 
                return _lyd;
            }
            set
            { 
                _lyd = value;
            }
        }
        // Metode: speak
        public void speak()
        {
            Console.WriteLine($"The dog says {sound}");
        }
    }
}
