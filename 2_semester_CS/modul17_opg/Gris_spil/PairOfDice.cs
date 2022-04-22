
namespace modul17_opg
{
    public class PairOfDice : Dice
    {
        public Dice Terning1 { get; }
        public Dice Terning2 { get; }
        

        public PairOfDice(Dice førsteTerning, Dice andenTerning) : base()
        {
            Terning1 = førsteTerning;
            Terning2 = andenTerning;
        }

        // Metoder
        public void ThrowDices()
        {
            Terning1.Throw();
            Terning2.Throw();
        }
        public int GetTerningerValues()
        {
            return Terning1.show() + Terning2.show();
        }
    }
}
