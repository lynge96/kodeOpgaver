using Model;

using (var db = new TaskContext())
{
    Console.WriteLine($"Database path: {db.DbPath}.");
    
    // // Create
    // Console.WriteLine("Indsæt et nyt task");
    // db.Add(new TodoTask("En opgave der skal løses", false, "Bipbop"));
    // db.SaveChanges();

    // // Read
    // Console.WriteLine("Find det sidste task");
    // var lastTask = db.Tasks
    //     .OrderBy(b => b.TodoTaskId)
    //     .Last();
    // Console.WriteLine($"Text: {lastTask.Text}");

    // // Update
    // Console.WriteLine("Opdaterer en task");
    // var updTask = db.Tasks
    //     .Where(x => x.TodoTaskId == 1)
    //     .First();
    //     updTask.Text = "Ostepops";

    //     db.SaveChanges();

    // Delete
    // Console.WriteLine("Sletter en bestemt task");

    // Console.WriteLine("Indtast et ID der skal slettes");
    // int input = int.Parse(Console.ReadLine());

    // var delTask = db.Tasks
    //     .Where(d => d.TodoTaskId == input); 
        
    //     db.SaveChanges();

}

