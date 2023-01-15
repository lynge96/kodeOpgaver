using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();

builder.Services.AddAuthentication("DummyAuthentication")
                .AddScheme<AuthenticationSchemeOptions, DummyAuthenticationHandler>("DummyAuthentication", null);

builder.Services.AddAuthorization(options => {
    options.AddPolicy("LikesCake", policy => policy.RequireClaim("Role", "CakeLover"));
    options.AddPolicy("Admin", policy => policy.RequireClaim("Role", "Admin"));
});
builder.Services.AddHttpContextAccessor();


var app = builder.Build();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapGet("/api/cake", [Authorize(Policy= "LikesCake")]
    () => {
        return "Hello Cake Lover!";
    });

app.MapGet("/api/admin", [Authorize(Policy= "Admin")]
    () => {
        return "Hello Admin!";
    });    

app.MapGet("/api/hello", [AllowAnonymous]
    () => "Hello World!");

app.MapGet("/", [AllowAnonymous]
    () => "Welcome to the front page");    

Console.WriteLine("App starting up!");

app.Run();




