
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;
using System.Text.Unicode;

internal class Program
{
    private static async Task Main(string[] args)
    {
        var client  = new HttpClient();
        var json = JsonSerializer.Serialize(new Employee{Name = "hamza"});
        var content = new StringContent(json, Encoding.UTF8, "application/json");
        var res = await client.PostAsync(
            "http://localhost:5138",
            content
        );

        var c = await res.Content.ReadAsStringAsync();
        Console.Write(c);
    }
}

record Employee {
    public string Name {get; set;}
}