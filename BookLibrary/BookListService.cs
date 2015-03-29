using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NLog;
using System.IO;


namespace BookLibrary
{
    public class BookListService
    {
        private static Logger logger;
        private string fileName = @"D:\BinaryRepository.bin";
        private IBookRepository repository;
        private IEnumerable<Book> books;
        public BookListService()
        {
            logger = LogManager.GetCurrentClassLogger();
            repository = new BinaryFileRepository(fileName);
            books = repository.LoadBooks();
        }

        public void AddBook(Book newBook)
        {

            List<Book> bookListForAdd = new List<Book>();
            var books = repository.LoadBooks();

            if (books.Contains(newBook))
            {
                logger.Debug("Book already exists; Book: {0}", newBook);
                
            }

            bookListForAdd.Add(newBook);
            repository.SaveBooks(bookListForAdd);
        }
        
        
        public void SortBooks(Comparison<Book> comparer)
        {
            Book[] bookArray = books.ToArray();
            Array.Sort<Book>(bookArray, comparer);
            books = bookArray.ToList<Book>();
            repository.SaveBooks(books);

        }

        public IEnumerable<Book> GetAllBooks()
        {
            return books;
        }

        //Попробовал LINQ первый 
        public IEnumerable<Book> GetBooksByAuthor(string author)
        {
            books = books.Where(book => author == book.Author);
            return books;
        }
        // второй
        public IEnumerable<Book> GetBooksByTitle(string title)
        {

            return books = from book in books
                           where book.Title == title
                           select book;
        }

    }
}
