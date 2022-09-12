var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Questions[] Quiz = new Questions[]
{
    new Questions { Id = 1, Spørgsmål = "Hvor mange brødre har Jacob?", SvarMuligheder = new string[] { "En", "To", "Tre", "Fire" }, SvarIndex = 1 },
    new Questions { Id = 2, Spørgsmål = "Hvilken drik har Jacob på foden?", SvarMuligheder = new string[] { "Sambuca", "Whisky", "Øl", "Vand"}, SvarIndex = 2 },
    new Questions { Id = 3, Spørgsmål = "Hvor kommer Anders fra?", SvarMuligheder = new string[] { "Kolt", "Skanderborg", "Skagen", "Kolding"}, SvarIndex = 0}
};

app.MapGet("/api/questions", () => Quiz);

app.MapGet("/api/questions/{id}", (int id) => Quiz.Where(i => i.Id == id));

app.Run();

public class Questions
{
    public int Id { get; set; }
    public string Spørgsmål { get; set; }
    public string[] SvarMuligheder { get; set; }
    public int SvarIndex { get; set; }
}
