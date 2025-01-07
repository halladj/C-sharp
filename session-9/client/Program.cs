using System.Runtime.CompilerServices;
using System.Text;
using System.Text.Json;

var client = new HttpClient();

var json = JsonSerializer.Serialize<Task>(new Task(
    1,
    "Play football",
    "Not Importnat"
));

var content = new StringContent(
    json, 
    Encoding.UTF8,
    "application/json"
);

var res = await client.PostAsync(
    // "http://192.168.0.7:5566",
    "http://localhost:5185/task",
    content
);

var s = await res.Content.ReadAsStringAsync();

Console.WriteLine(s);