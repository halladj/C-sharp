using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var employees = new List<Employee>();
employees.Add(new Employee{FirstName = "Hamza", LastName="Ronaldo", Id=1, SocialSecurityNumber="123-45-3445"});
employees.Add(new Employee{FirstName = "Cris", LastName="Ronaldo", Id=2, SocialSecurityNumber="123-45-3445"});

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

var employeeRoute =  app.MapGroup("employees");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

employeeRoute.MapGet(string.Empty, ()=>{
    return Results.Ok(employees);
});


employeeRoute.MapGet("{id:int}", ([FromRoute]int id) => {
    var employee = employees.SingleOrDefault(e => e.Id == id);
    if (employee == null)
    {
        return Results.NotFound();
    }
    return Results.Ok(employee);
});

employeeRoute.MapPut("{id}", ([FromBody]Employee employee, int id) => {
    var existingEmployee = employees.SingleOrDefault(e => e.Id == id);
    if (existingEmployee == null)
    {
        return Results.NotFound();
    }

    existingEmployee.FirstName = employee.FirstName;
    existingEmployee.LastName = employee.LastName;
    existingEmployee.Address1 = employee.Address1;
    existingEmployee.Address2 = employee.Address2;
    existingEmployee.City = employee.City;
    existingEmployee.State = employee.State;
    existingEmployee.ZipCode = employee.ZipCode;
    existingEmployee.PhoneNumber = employee.PhoneNumber;
    existingEmployee.Email = employee.Email;

    return Results.Ok(existingEmployee);
});


employeeRoute.MapPost(string.Empty, ( [FromBody] Employee employee) => {
    employee.Id = employees.Max(e => e.Id) + 1; // We're not using a database, so we need to manually assign an ID
    employees.Add(employee);
    return Results.Created($"/employees/{employee.Id}", employee);
});
app.Run();

public partial class Program{}