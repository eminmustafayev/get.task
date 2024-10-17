using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Library
    {
        Book[] Books;
        int bookCount;

        public Library(int capacity) { 
        Books = new Book[capacity];
                           }
        public void AddBook(Book book)
        {
            if (bookCount < Books.Length)
            {
                Books[bookCount++] = book;
                bookCount++;
            }
            else
            {
                Console.WriteLine("yaddas dooludu");
            }
        }
        public Book[] GetFilteredBooks(int minPrice , int maxPrice)
        {
            return Books.Where(b => b != null && b.price >= minPrice && b.price <= maxPrice).ToArray();  
        }
        public Book[] GetFilteredBooks(string genre)
        {
            return Books
                .Where(b => b != null && b.Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                .ToArray();
        }
        public void ShowAllBooks()
        {
            foreach(var  book in Books)
            {
if(book != null)
                {
                    book.ShowInfo();
                }
            }
        }
    }
}
