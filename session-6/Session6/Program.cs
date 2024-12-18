namespace System.Text.Json;
class Program
{
    private static void Main(string[] args)
    {
       var employee = new Employee()
        {
            Id = 1,
            FirstName = "John",
            LastName = "Doe",
            Age = 30
        };

        var json = JsonSerializer.Serialize(employee);
        var johnReborn = JsonSerializer.Deserialize<Employee>(json); 

        File.AppendAllLines("hamza.txt", [json]);

        var readdd = File.ReadAllLines("hamza.txt");
        foreach (var item in readdd)
        {
            var Empobj = JsonSerializer.Deserialize<Employee>(item); 
            Console.WriteLine(item);
        }

    }
}


public record Employee{
    public int Id {get; set;}
    public string? FirstName {get; set;}
    public string? LastName {get; set;}
    public int Age {get; set;}
}