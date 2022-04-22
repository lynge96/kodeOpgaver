
namespace modul17_opg
{
    public class Dice
    {
        private Int32 _eyes;

        Random rand = new Random();

        public Dice()
        {
            Throw();
        }

        public void Throw()
        {
            _eyes = rand.Next(1, 7);
        }

        public Int32 show()
        {
            return _eyes;
        }
    }
}