using System;
// var builder = WebApplication.CreateBuilder(args);
// var app = builder.Build();

// // Tilføj DbContext factory som service
// builder.Services.AddDbContext<TaskContext>(options =>
//     options.UseSqlite(builder.Configuration.GetConnectionString("TaskContextSQLite")));


// String[] frugter = new String[]
// {
//     "æble", "banan", "pære", "ananas"
// };

using (var db = new FruitContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    
    // Create
    Console.WriteLine("Indsæt en ny frugt");
    db.Add(new Fruit("Fersken"));
    db.SaveChanges();

    // Read
    Console.WriteLine("Find den sidste frugt");
    var lastFruit = db.Fruits
        .OrderBy(b => b.FruitId)
        .Last();
    Console.WriteLine($"Text: {lastFruit.Navn}");
}



// app.Run();

