using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text.Json;

public class Program{
    public static void Main(string[] Args){
        //Checks if a file exists.
        // var p = Path.Exists("Program.cs");

        // Joins the path
        // var p1 = Path.Combine("/home/hambz/c#/session-1/Session1","Program.cs");
        // Console.WriteLine(p1);
        // Console.WriteLine(Path.Exists(p1));

        // var p2  = @"/home/hambz/c#/session-7/Session7/Program.cs";
        // Console.WriteLine(Path.EndsInDirectorySeparator(p2));
        // Console.WriteLine(Path.GetFileName(p2));
        // Console.WriteLine(Path.GetExtension(p2));
        // Console.WriteLine(Path.GetFileNameWithoutExtension(p2));
        //
        // var p2  = @"Program.cs";
        // // Console.WriteLine(Path.GetFullPath(p2));
        // var x = Path.GetFullPath(p2);
        // var li = x.Split(@"/"); 

        // foreach (var item in li)
        // {
        //     Console.WriteLine(item);
        // }

        // var p3  = Path.Combine(li);
        // Console.WriteLine(@"/"+ p3);


        //////////////////////////////////////////////////////////////////
        /////                          Dirs                           ////                                      
        //////////////////////////////////////////////////////////////////
        // var d = Directory.GetCurrentDirectory();
        // Console.WriteLine(d);

        // var d1 = Directory.GetFiles(d);
        // foreach (var item in d1)
        // {
        //     Console.WriteLine(Path.GetFileName(item));
        // }

        // var d2 = Directory.GetDirectories(d);
        // foreach (var item in d2)
        // {
        //     Console.WriteLine(Path.GetFileName(item));
        // }

        // Console.WriteLine(Directory.GetDirectoryRoot(d));

        // try 
        // {
        //     Directory.CreateDirectory("Houssam");
        //     Directory.SetCurrentDirectory("Houssam");
        //     Directory.CreateDirectory("Ronaldo");
        //     Directory.SetCurrentDirectory("../");
        //     throw new Exception();
        // }
        // catch(Exception)
        // {
        //     Thread.Sleep(2000);
        //     if (Directory.Exists("Houssam")){
        //         Console.WriteLine("Error creating the directory...");
        //         Console.WriteLine("Deleting the dir...............");
        //         Directory.SetCurrentDirectory("Houssam");
                
        //         Directory.Delete("Ronaldo");
        //         Directory.SetCurrentDirectory("../../");
        //         Console.WriteLine();
                
        //         Directory.Delete("Houssam");

        //     }
        // }


        // var em1 = new Employee{
        //     Name = "Ronaldo",
        //     age  = 40,
        // };

        // var employeeJson = JsonSerializer.Serialize<Employee>(em1);

        // File.AppendAllText("Employees.json", employeeJson);

        var readJson = File.ReadAllText("Employees.json");
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
