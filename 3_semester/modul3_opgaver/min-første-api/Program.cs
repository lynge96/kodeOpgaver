var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/api/hello", () => new { Message = "Hello world!"});

app.MapGet("/api/hello/{name}", (string name) => new { Message = $"Hello {name}!"});

app.MapGet("/api/hello/{name}/{age}", (string name, int age) => new { Message = $"Hello {name} du er {age} år gammel!"});

app.Run();
