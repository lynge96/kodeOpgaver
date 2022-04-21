using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg16._02
{
    public class Værkfører : Mekaniker
    {

        public int UdnævnelsesÅr { get; set; }
        public int UgeTillæg { get; set; }

        public Værkfører(string Navn, string Adresse, int Årbestået, int Timeløn, int UdnævnelsesÅr, int UgeTillæg) : base(Navn, Adresse, Årbestået, Timeløn)
        {
            this.UdnævnelsesÅr = UdnævnelsesÅr;
            this.UgeTillæg = UgeTillæg;
        }
        public override string ToString()
        {
            string VærkførerProperties = $"{Navn} bor på {Adresse}." +
                $"\n{Navn} bestod sin mekanikerprøve i {ÅrBestået} og tjener {Timeløn} i timen." +
                $"\nBlev udnævnt som værkfører i år {UdnævnelsesÅr} og får {UgeTillæg} i ugetillæg";

            return VærkførerProperties;
        }

        public override double BeregnUgeLøn()
        {
            return TimerPrUge * Timeløn + UgeTillæg;
        }

    }
}