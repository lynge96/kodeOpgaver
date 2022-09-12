using System;
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

String[] frugter = new String[]
{
    "�ble", "banan", "p�re", "ananas"
};


var rng = new Random();

// Returnerer hele frugt-arrayet.
app.MapGet("/api/fruit", () => frugter);

// Returnerer navnet p� en bestemt frugt. Frugten findes i dit frugt-array under index, som er et tal.
app.MapGet("/api/fruit/{index}", (int index) => frugter[index]);

// Returnerer navnet p� en tilf�ldig frugt, dvs. en frugt med et tilf�ldigt index i arrayet.
app.MapGet("/api/fruit/random", () => frugter[rng.Next(frugter.Length)]);


// Tilf�jer en ny frugt til arrayet.
app.MapPost("/api/fruit", (Fruit fruit) =>
{
    frugter = frugter.Append(fruit.name).ToArray();

    Console.WriteLine($"Tilf�jer frugt: {fruit.name}");

    return frugter;
});

app.Run();

record Fruit(string name);