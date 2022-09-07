var builder = WebApplication.CreateBuilder(args);

// Åben op for "CORS" i din API.
// Læs om baggrunden her: https://docs.microsoft.com/en-us/aspnet/core/security/cors?view=aspnetcore-6.0

var AllowCors = "_AllowCors";
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowCors, builder => {
        builder.AllowAnyOrigin()
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

var app = builder.Build();
app.UseCors(AllowCors);

int nextID = 0;

Tasks[] ToDoListe = new Tasks[] {
  new Tasks {Id = nextID++, Text = "støvsug", Done = false},
  new Tasks {Id = nextID++, Text = "vask gulv", Done = false},
  new Tasks {Id = nextID++, Text = "tøjvask", Done = true}
};

app.MapGet("/api/tasks", () => ToDoListe);

app.MapGet("/api/tasks/{id}", (int id) => ToDoListe.Where(i => i.Id == id));

app.MapPut("/api/tasks/{id}", (int id, Tasks opg) => {

  return ToDoListe = ToDoListe.Select(x =>
  {
    if (x.Id == id) {
      x = opg;
      x.Id = id;
      return x;
    } else {
      return x;
    }
  }).ToArray();
});

app.MapDelete("/api/tasks/{id}", (int id) => ToDoListe = ToDoListe.Where(x => x.Id != id).ToArray());

app.MapPost("/api/tasks/", (Tasks nyTask) => {
  nyTask.Id = nextID++;
  return ToDoListe = ToDoListe.Append(nyTask).ToArray();
});

app.Run();


public class Tasks {
  public int Id { get; set; }
  public string Text { get; set; }
  public bool Done { get; set; }
}