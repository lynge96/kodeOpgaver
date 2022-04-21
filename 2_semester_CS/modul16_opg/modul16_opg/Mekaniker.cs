namespace opg16._02
{
    public class Mekaniker : Person
    {

        public int ÅrBestået { get; set; }
        public int Timeløn { get; set; }

        public Mekaniker(string Navn, string Adresse, int Årbestået, int Timeløn) : base(Navn, Adresse)
        {
            this.ÅrBestået = Årbestået;
            this.Timeløn = Timeløn;
        }

        public override string ToString()
        {
            string MekanikerProperties = $"{Navn} bor på {Adresse}" +
                $"\nHan bestod sin mekanikerprøve i {ÅrBestået} og tjener {Timeløn} i timen.";
            
            return MekanikerProperties;
        }

        public override double BeregnUgeLøn()
        {
            return TimerPrUge * Timeløn;
        }

    }
}
