
namespace modul17_opg
{
    public class GrisPlayer : Player
    {
        // Properties
        public bool Færdig { get; set; }
        public PairOfDice Terninger { get; set; }

        public int pointRunde = 0;

        // Constructor
        public GrisPlayer(String navn, int playerpoint, bool færdig, PairOfDice terninger) : base(navn, playerpoint)
        {
            Færdig = færdig;
            Terninger = terninger;
        }

        // Metoder
        public void KastTerningerne()
        {
            Færdig = false;

            Terninger.ThrowDices();

            Console.WriteLine($"\n{PlayerNavn} kaster terningerne og slår {Terninger.Terning1.show()} og {Terninger.Terning2.show()}");

            PointDenneRunde();
            Console.WriteLine($"Samlet point denne runde: {pointRunde}");
        }

        private int PointDenneRunde()
        {
            pointRunde += Terninger.GetTerningerValues();

            return pointRunde;
        }

        private int PointSamlet()
        {
            PlayerPoint += pointRunde;

            Console.WriteLine($"{PlayerNavn} score er nu {PlayerPoint}!");

            return PlayerPoint;
        }

        public int EndTurn()
        {
            int pointRunde = 0;
            Færdig = true;

            PointSamlet();
            Console.WriteLine("Turen er nu slut.");

            return pointRunde;
        }


    }
}
