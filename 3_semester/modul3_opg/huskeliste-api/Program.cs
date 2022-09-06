var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Tasks[] ToDoListe = new Tasks[] {
  new Tasks {Id = 0, Text = "støvsug", Done = false},
  new Tasks {Id = 1, Text = "vask gulv", Done = false},
  new Tasks {Id = 2, Text = "tøjvask", Done = true}
};

app.MapGet("/api/tasks", () => ToDoListe);

app.MapGet("/api/tasks/{id}", (int id) => ToDoListe.Where(i => i.Id == id));

app.MapPut("/api/tasks/{id}", (int id, Tasks opg) => ToDoListe.Where(i => i.Id == id).Select(i => new Tasks { Id = i.Id, Text = i.Text, Done = i.Done}));

app.Run();


public class Tasks {
  public int Id { get; set; }
  public string Text { get; set; }
  public bool Done { get; set; }
}