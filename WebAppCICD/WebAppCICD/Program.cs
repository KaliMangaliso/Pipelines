
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello from WebAppCICD!");
app.MapGet("/health", () => Results.Ok("OK"));

app.Run();
