// var request = new HttpRequestMessage(
//     HttpMethod.Get,
//     "https://microsoft.com"
// );

// Console.WriteLine(request);

// var client = new HttpClient();
// var response  = await client.SendAsync(request);
// Console.WriteLine(response);


// var client = new HttpClient();

// var response = await client.GetAsync("https://microsoft.com");
// var content = await response.Content.ReadAsStringAsync();

// Console.Write(content);


using System.Text;
using System.Text.Json;
using Microsoft.VisualBasic;

var client = new HttpClient();

var json = JsonSerializer.Serialize<Employee>(
    new Employee{
        Name = "Ronaldo",
        age  = 20
    }
);

var content = new StringContent (json, Encoding.UTF8, "application/json");

var res = await client.PostAsync(
    "http://192.168.28.105:5000",
    content
);

Console.WriteLine(res);


public record Employee {
    public string Name{get; set;}
    public int age {get; set;}
}
