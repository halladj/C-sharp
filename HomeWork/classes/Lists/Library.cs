
public class Library : ILibrary
{
    public List<IBook> Books { get; set;}
    public Library()
    {
        Books = new List<IBook>();
    }

    public void AddBook(IBook book)
    {
        Books.Add(book);
    }

    public void DisplayAll()
    {
        foreach (var book in Books)
        {
            book.DisplayInfo();
        }
    }
}