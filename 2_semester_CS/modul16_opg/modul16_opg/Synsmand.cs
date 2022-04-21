using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg16._02
{
    public class Synsmand : Mekaniker
    {

        public int AntalSyn { get; set; }

        public Synsmand(string Navn, string Adresse, int Årbestået, int Timeløn, int AntalSyn) : base(Navn, Adresse, Årbestået, Timeløn)
        {
            this.AntalSyn = AntalSyn;
        }

        public int GetUgeløn(int antalSyn)
        {
            int synPris = 290;

            return antalSyn * synPris;
        }

        public override string ToString()
        {
            string SynsmandProperties = $"{Navn} bor på {Adresse}." +
                $"\n{Navn} bestod sin mekanikerprøve i {ÅrBestået} og tjener {Timeløn} i timen." +
                $"\nI dag er {Navn} synsmand og har {AntalSyn} syn pr. uge";

            return SynsmandProperties;
        }

        public override double BeregnUgeLøn()
        {
            return GetUgeløn(AntalSyn);
        }

    }
}
