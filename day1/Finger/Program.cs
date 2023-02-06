using Finger;
using Marten;

var builder = WebApplication.CreateBuilder(args);

var connectionString = "host=localhost;database=status_dev;password=TokyoJoe138!;username=postgres;port=5432";

builder.Services.AddMarten(options =>
{
    options.Connection(connectionString);
    if (builder.Environment.IsDevelopment())
    {
        options.AutoCreateSchemaObjects = Weasel.Core.AutoCreate.All;
    }
});

var app = builder.Build();

app.MapGet("/status", () => {
    var status = new StatusMessage("All is good.", DateTimeOffset.Now);
    return status;
});

app.MapPost("/status", (StatusRequest req) => {
    return req;
});


app.Run();

public record StatusRequest(string Message);
