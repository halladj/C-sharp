public class Book : IBook
{
    public string? Name { get; set; }
    public string? Description { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"BookName: {Name}, Description: {Description}");
    }

    override
    public string? ToString (){
        return $"BookName: {Name}, Description: {Description}";
    } 
}