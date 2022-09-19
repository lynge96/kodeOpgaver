// Fruit.cs
namespace Model
{
    public class Fruit
    {
        public Fruit(string frugt) {
            this.Navn = frugt;
        }
        public long FruitId { get; set; }
        public string? Navn { get; set; }
    }
}
