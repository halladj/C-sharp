
using System.Text.Json;

public class FileLibrary : ILibrary
{
    public List<IBook> Books { get; set; }

    private const string FILE_NAME= "LIBRARY_DB.json";

    public FileLibrary()
    {   
        Books = new List<IBook>();

        if (File.Exists(FILE_NAME))
        {
            var content = File.ReadAllLines(FILE_NAME);
            foreach (var item in content)
            {
                if (!string.IsNullOrWhiteSpace(item))
                {
                    var o = JsonSerializer.Deserialize<Book>(item);
                    Books.Add(o);
                }
                
            }
        }
        else
        {
            using ( var file = File.Create(FILE_NAME))
            {
                file.Close();
            }
        }
    }

    public void AddBook(IBook book)
    {
        // same code as before.
        Books.Add(book);

        // add it to the file.

        // Convert List<IBook> to a List<string>
        // using JsonSerialize.Serialize();
        List<string> temp = new List<string>();
        foreach (var item in Books)
        {
            temp.Add(JsonSerializer.Serialize<IBook>(item));
        }

        File.WriteAllLines(FILE_NAME, temp.ToArray());
    }

    public void DisplayAll()
    {
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }
}