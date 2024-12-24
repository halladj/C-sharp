
public class FileLibrary : ILibrary
{
    public List<IBook> Books { get; set; }

    private const string FILE_NAME= "LIBRARY_DB";

    FileLibrary(){
        Books = new List<IBook>();
        string[] temp;
        if (File.Exists(FILE_NAME)){
            temp = File.ReadAllLines(FILE_NAME);

            foreach (var item in temp)
            {   var s = item.Split(",");
                Books.Add(new Book{
                    Name = s[0], 
                    Description= s[1]
                });
            }
        }else
        {
            using (var f = File.Create(FILE_NAME))
            {
                f.Close();
            }
        }
    }

    public void AddBook(IBook book)
    {
        // same code as before.

        // add it to the file.
    }

    public void DisplayAll()
    {
        // same code as before
    }
}