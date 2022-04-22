
namespace modul17_opg
{
    public class Player
    {
        public String PlayerNavn { get; set; }
        public int PlayerPoint { get; set; }


        // Constructor
        public Player(String navn, int point)
        {
            PlayerNavn = navn;
            PlayerPoint = point;
        }
    }
}
