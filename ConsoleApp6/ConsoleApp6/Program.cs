namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Library library = new Library(3);

            Book book1 = new Book(1, "Dede Qorqud", 10, 23, "Romantik");
            Book book2 = new Book(2, "Koroglu", 20, 33, "Drama");
            Book book3 = new Book(3, "Harry Poter", 30, 63, "Edebiyyat");

            library.AddBook(book1);
            library.AddBook(book2);
            library.AddBook(book3);

            Console.WriteLine("Butun Kitablar");
            library.ShowAllBooks();

            Console.WriteLine("qiymeeti 10 ve 30 arasinda olan kitablar");
            var filteredBooksByPrice = library.GetFilteredBooks(10, 30);
            foreach (var book in filteredBooksByPrice)
            {
                book.ShowInfo();
            }
            Console.WriteLine("\n'Drama' janrındaki kitablar:");
            var filteredBooksByGenre = library.GetFilteredBooks("Drama");
            foreach (var book in filteredBooksByGenre)
            {
                book.ShowInfo();
            }
        }
    }
}