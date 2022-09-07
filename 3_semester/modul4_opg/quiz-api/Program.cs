var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Questions[] Quiz = new Questions[]
{
    new Questions { Id = 1, Spørgsmål = "Hvor mange br�dre har Jacob?", SvarMuligheder = new string[] { "En", "To", "Tre", "Fire" }, SvarIndex = 1 },
    new Questions { Id = 2, Spørgsmål = "Hvilken drik har Jacob p� foden?", SvarMuligheder = new string[] { "Sambuca", "Whisky", "�l", "Vand"}, SvarIndex = 2 },
    new Questions { Id = 3, Spørgsmål = "Hvor kommer Anders fra?", SvarMuligheder = new string[] { "Kolt", "Skanderborg", "Skagen", "Kolding"}}
};

app.Run();

app.MapGet("/api/questions", () => Quiz);




public class Questions {
    public int Id { get; set; }
    public string Spørgsmål { get; set; }
    public string[] SvarMuligheder { get; set; }
    public int SvarIndex { get; set; }
}
