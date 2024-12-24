public interface ILibrary{
    List<IBook> Books {get; set;} 

    void AddBook(IBook book);
    void DisplayAll();
}