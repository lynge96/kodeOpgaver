var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String[] frugter = new String[]
{
    "æble", "banan", "pære", "ananas"
};


var rng = new Random();

// Returnerer hele frugt-arrayet.
app.MapGet("/api/fruit", () => frugter);

// Returnerer navnet på en bestemt frugt. Frugten findes i dit frugt-array under index, som er et tal.
app.MapGet("/api/fruit/{index}", (int index) => frugter[index]);

// Returnerer navnet på en tilfældig frugt, dvs. en frugt med et tilfældigt index i arrayet.
app.MapGet("/api/fruit/random", () => frugter[rng.Next(frugter.Length)]);


// Tilføjer en ny frugt til arrayet.
app.MapPost("/api/fruit", (Fruit fruit) =>
{
  frugter = frugter.Append(fruit.name).ToArray();

  Console.WriteLine($"Tilføjer frugt: {fruit.name}");

  return frugter;    
});

app.Run();

record Fruit(string name);