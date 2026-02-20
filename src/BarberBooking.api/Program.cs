var builder = WebApplication.CreateBuilder(args);

builder.Services.AddProblemDetails();
builder.Services.AddHealthChecks();

var app = builder.Build();

app.UseExceptionHandler();
app.MapHealthChecks("/health");
app.MapGet("/", () => Results.Ok("Barber booking API is running"));

app.UseHttpsRedirection();

app.Run();
