using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();
var  employees = new List<Employee>();

employees.Add(
    new Employee {Name = "Ronaldo"}
);
employees.Add(
    new Employee {Name = "Messi"}
);

// Arrow function (Lambda function)
app.MapGet("/", () => {
    return Results.Ok("Employees Home Page");
});

app.MapGet("/employee", () => {
    var json  = JsonSerializer.Serialize<Employee[]>(employees.ToArray());

    return Results.Ok(json);
});

app.Run();




public record Employee {
    public string? Name{get; set;}
}