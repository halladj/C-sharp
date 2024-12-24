Book book1 = new Book{
    Name = "Distributed Computing", 
    Description = "Principles, Algorithms, and Systems"
};

Book book2 = new Book{
    Name = "Harry Potter", 
    Description = "The new potter book"
};
// book1.DisplayInfo();
// Console.WriteLine(book1);

Book book3 = new Book{};
book3.Name        = Console.ReadLine();
book3.Description = Console.ReadLine();

Library lib = new Library();
lib.AddBook(book1);
lib.AddBook(book2);
lib.AddBook(book3);

lib.DisplayAll();