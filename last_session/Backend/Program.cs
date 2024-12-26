using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();


app.MapGet("/", () =>
{
    // Send all the TODOs as json
});

app.MapPost("/", async(Employee employee )=>{

    //TODO: Store the TODO it somewhere.
    Console.WriteLine();
    return Results.Ok("sucess !");
});

app.Run();

record Employee{
    public string? Name{get; set;}
}
