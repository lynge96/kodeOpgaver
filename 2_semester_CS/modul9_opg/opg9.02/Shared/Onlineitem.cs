using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg9._02.Shared
{
    public class Onlineitem : ShoppingItem
    {
        // Properties
        public float Price { get; set; }

        public String Description { get; set; }

        public String Category { get; set; }


        // Constructor
        public Onlineitem(float pris, String beskrivelse, String kategori, String Title, bool IsDone) : base (Title, IsDone)
        {
            this.Price = pris;
            this.Description = beskrivelse;
            this.Category = kategori;
        }

        public Onlineitem()
        {   

        }

    }
}
