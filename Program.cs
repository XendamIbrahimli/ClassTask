namespace C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            Library library = new Library();

            Book book = new Book(12, "T200", "Nano", "Scientific");
            Book book1 = new Book(20, "B54", "BBB", "Drama");
            Book book2 = new Book(15, "G50", "CCC", "Comedy");
            Book book3 = new Book(18, "GG5", "HHH", "Drama");
            Book book4 = new Book(8, "J8I", "JJJ", "Adventure");
            Book book5 = new Book(25, "12W", "QQQ", "Love");
            Book book6 = new Book(22, "BHT", "OPP", "Drama");
            //book.ShowInfo();

            library.AddBook(book);
            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);
            library.AddBook(book4);
            library.AddBook(book5);
            library.AddBook(book6);

            library.GetFilteredBooks("Drama");
            //library.GetFilteredBooks(5, 20);
            //library.ShowAllBooks();




        }
    }


}
