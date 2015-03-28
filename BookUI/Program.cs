using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookLibrary;

namespace BookUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book() { Author = "Алан Гинзберг", Title = "Вопль", ISBN = 226611156, Gerne = "Поэма" };
            Book book1 = new Book() { Author = "Алан Гинзберг", Title = "Вопль", ISBN = 226611156, Gerne = "Поэма" };
            Console.WriteLine(book.Equals(book1));

            BookListService bookService = new BookListService();

            //bookService.AddBook(new Book() { Author = "Алан Гинзберг", Title = "Вопль", ISBN = 226611156, Gerne = "Поэма" });
            //bookService.AddBook(new Book() { Author = "Джек Керуак", Title = "В дороге", ISBN = 226611157, Gerne = "Роман" });

            var bookList = bookService.GetAllBooks();
            Console.WriteLine(bookList.ToArray()[0]);
            Console.WriteLine(bookList.ToArray()[1]);
         


            Console.ReadKey();

        }
    }
}
