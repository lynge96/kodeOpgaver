var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Questions[] Quiz = new Questions[]
{
    new Questions { Id = 1, Spørgsmål = "Hvor mange brødre har Jacob?", SvarMuligheder = new string[] { "En", "To", "Tre", "Fire" }, SvarIndex = 1 },
    new Questions { Id = 2, Spørgsmål = "Hvilket band har Anders tattoveret på armen?", SvarMuligheder = new string[] { "Slipknot", "Sleep Token", "While She Sleeps", "Bring Me The Horizon"}, SvarIndex = 3 },
    new Questions { Id = 3, Spørgsmål = "Hvor kommer Anders fra?", SvarMuligheder = new string[] { "Kolt", "Skanderborg", "Skagen", "Kolding"}, SvarIndex = 0},
    new Questions { Id = 4, Spørgsmål = "Hvor mange bøger har Anders?", SvarMuligheder = new string[] { "45", "66", "12", "34"}, SvarIndex = 1}
};
// Henter alle spørgsmål
app.MapGet("/api/questions", 
    () => {
        var res = Quiz.Select(p => new { 
            p.Id, 
            p.Spørgsmål, 
            p.SvarMuligheder
        });

        return res;
    });
// Henter et specifikt spørgsmål ud fra ID
app.MapGet("/api/questions/{id}", 
    (int id) => {
        var res = Quiz.Where(s => s.Id == id).Select(p => new {
            p.Id,
            p.Spørgsmål,
            p.SvarMuligheder
        });

        return res;
    });

// Tjekker om man har svaret rigtigt eller forkert
app.MapPost("/api/questions/{id}/validate", 
    (int id, SvarMulighed svaret) => {  
        var res = Quiz.Where(q => q.Id == id).Select(x => x.SvarIndex).First();

        return (svaret.Svar == Quiz[id].SvarMuligheder[res].ToString()) ? true : false;
    });

app.Run();

public class Questions
{
    public int Id { get; set; }
    public string? Spørgsmål { get; set; }
    public string[]? SvarMuligheder { get; set; }
    public int SvarIndex { get; set; }
}
record SvarMulighed(string Svar);