using Model;
using System.Collections.Generic;

using (var db = new BoardContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    
    // // Finder første User
    // User førsteBruger = db.User
    //     .OrderBy(b => b.UserId)
    //     .First();
    // Console.WriteLine($"Første user: {førsteBruger.Name}");

    // // // Create Todo
    // Console.WriteLine("Opretter en ny todo");
    // db.Add(new Todo("Vasketøj", "Rengøring", førsteBruger));
    // db.SaveChanges();

    // // Read Todo
    // Console.WriteLine("Find den sidste todo");
    // var lastTodo = db.Todo
    //     .OrderBy(b => b.TodoId)
    //     .Last();
    // Console.WriteLine($"Text: {lastTodo.Name}");

    // // Create Board
    // var liste = db.Todo.Where(t => t.TodoId == 1).Last();

    // Console.WriteLine("Opretter et board");
    // db.Add(new Board( new List<Todo>() { liste } ));
    // db.SaveChanges();


}