using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
 
}


app.Use(async (HttpContext context, RequestDelegate next) =>
{
    context.Response.Headers.Append("Content-Type", "text/html");
    await context.Response.WriteAsync("<h1>Welcome to Ahoy!</h1>");
});



TodoStore s = new TodoStore();

// Restfull API Design

// retutnd all tasks as json.
app.MapGet("/task", () =>{
    return Results.Ok(s);
});

// return one task with id.
app.MapGet("/task/{id:int}", ([FromRoute] int id) =>{
    var temp = s.GetTask(id);
    if ( temp != null )
    {
        return Results.Ok(temp);
    }
    return Results.NotFound("Task Not Found");
});

// creates task from json.
app.MapPost("/task", ([FromBody] Task task) => {
    s.AddTask(task);

    return Results.Created();
} );

app.MapDelete("/task/{id:int}", ([FromRoute] int id) => {
    s.DeleteTask(id);
    return Results.Ok("Deleted Succesfuly");
});

app.MapPut("/task/{id:int}", ([FromRoute] int id, [FromBody] Task task) => {

    var item = s.GetTask(id);
    s.DeleteTask(id);

    s.AddTask(task);
    return Results.Ok("Updated Succesfuly");
});

app.Run();







