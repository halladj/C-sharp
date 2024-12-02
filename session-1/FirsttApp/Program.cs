// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


(string firstName,string lastName) returnInfo(){
    return ("hamza", "halladj");
}

var (f,l) = returnInfo();
Console.WriteLine(f,l);