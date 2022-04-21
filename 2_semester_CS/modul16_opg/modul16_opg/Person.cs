namespace opg16._02
{
    public class Person
    {
        public string Navn { get; set; }
        public string Adresse { get; set; }

        // Constructor
        public Person(string Navn, string Adresse)
        {
            this.Navn = Navn;
            this.Adresse = Adresse;
        }

        public override string ToString()
        {
            string PersonProperties = $"{Navn} bor på {Adresse}";

            return PersonProperties;
        }


        private const int _timerPrUge = 37;

        public virtual double BeregnUgeLøn()
        {
            return 0.0;
        }

        public int TimerPrUge  //og den tilhørende access metode, bemærk readOnly, dvs get!
        {
            get { return _timerPrUge; }
        }

    }
}