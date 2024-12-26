using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        // var em1 = new Employee{
        //     Name = "Ronaldo",
        //     age  = 40,
        // };

        // var em2 = new Employee{
        //     Name = "Houssem",
        //     age  = 99,
        // };
        // var employeeJson1 = JsonSerializer.Serialize<Employee>(em1);
        // var employeeJson2 = JsonSerializer.Serialize<Employee>(em2);

        // Console.WriteLine(employeeJson1);
        // Console.WriteLine(employeeJson2);

        // File.AppendAllLines("Employees.json", [ 
        //     employeeJson1, 
        //     employeeJson2, 
        // ]);

        var readJson = File.ReadAllLines("Employees.json");
        foreach (var item in readJson)
        {
            var temp = JsonSerializer.Deserialize<Employee>(item);
            Console.WriteLine(temp);
        }
    }
}



public record Employee { 
    public string? Name{ get; set;}
    public int age{ get; set;}
}