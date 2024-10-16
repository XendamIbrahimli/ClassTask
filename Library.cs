using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C1
{
    internal class Library
    {
        public Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }

        public void AddBook(Book book)
        {
            Book[] newBooks = new Book[Books.Length+1];
            for (int i = 0; i < Books.Length; i++)
            {
                newBooks[i] = Books[i];
            }

            newBooks[newBooks.Length-1] = book;
            Books = newBooks;
        }

       public void GetFilteredBooks(string genre)
        {
            for (int i = 0;i < Books.Length;i++)
            {
                if (Books[i].Genre == genre)
                {
                    Console.WriteLine($"{Books[i].Name}, {Books[i].No}, {Books[i].Genre}, {Books[i].Price}");
                }
            }
        }

        public void GetFilteredBooks(int minPrice, int maxPrice)
        {
            for(int i = 0; i<Books.Length; i++) 
            {
                if (Books[i].Price>minPrice && Books[i].Price < maxPrice)
                {
                    Console.WriteLine($"{Books[i].Name}, {Books[i].No}, {Books[i].Genre}, {Books[i].Price}");
                }
            }
        }

        public void ShowAllBooks()
        {
            foreach (Book book in Books)
            {
                Console.WriteLine($"{book.Name}, {book.No}, {book.Genre}, {book.Price}");
            }
        }
    }
}
