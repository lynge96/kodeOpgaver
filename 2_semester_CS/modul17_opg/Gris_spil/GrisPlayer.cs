
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
            Terninger.ThrowDices();
            Console.WriteLine($"\n{PlayerNavn} kaster terningerne og slår {Terninger.Terning1.show()} og {Terninger.Terning2.show()}\n");

            if (Terninger.Terning1.show() == 1 && Terninger.Terning2.show() == 1)
            {
                Thread.Sleep(650);

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Begge terninger landede på 1, så du mister alle dine point...");
                Console.ResetColor();
                PlayerPoint = 0;

                EndTurn();
            } 
            else if (Terninger.Terning1.show() == 1 || Terninger.Terning2.show() == 1)
            {
                Thread.Sleep(650);

                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Den ene terning landede på 1, så du mister alle point i denne runde...");
                Console.ResetColor();

                EndTurn();
            }
            else
            {
                Thread.Sleep(650);

                PointDenneRunde();
                Console.WriteLine($"Samlede point denne runde: {pointRunde}");
            }

        }

        private int PointDenneRunde()
        {
            pointRunde += Terninger.GetTerningerValues();

            return pointRunde;
        }

        public int PointSamlet()
        {
            PlayerPoint += pointRunde;
            pointRunde = 0;

            return PlayerPoint;
        }

        public int EndTurn()
        {
            Thread.Sleep(650);

            pointRunde = 0;
            Færdig = true;

            Console.WriteLine($"\nTuren er nu slut.\n{PlayerNavn} samlede score er {PlayerPoint}.");

            return pointRunde;
        }
    }
}