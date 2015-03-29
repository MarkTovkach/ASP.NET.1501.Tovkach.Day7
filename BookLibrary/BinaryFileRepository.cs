using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using NLog;

namespace BookLibrary
{
   public class BinaryFileRepository : IBookRepository
    {
        public static string FileName { get; private set; }

        private static Logger logger;

        public BinaryFileRepository(string fileName)
        {
            FileName = fileName;
            logger = LogManager.GetCurrentClassLogger();
        }

        public IEnumerable<Book> LoadBooks()
        {
            List<Book> books = new List<Book>();

            if (File.Exists(FileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(FileName, FileMode.Open)))
                {
                    while (reader.BaseStream.Position < reader.BaseStream.Length)
                    {
                        books.Add(new Book
                        {
                            Author = reader.ReadString(),
                            Title = reader.ReadString(),
                            ISBN = reader.ReadUInt32(),
                            Gerne = reader.ReadString()
                        });
                    }
                }

            }
            else
            {
                logger.Error("LoadBooks. File does not exist, FileName={0}", FileName); 
            }


            return books;
        }

        public void SaveBooks(IEnumerable<Book> books)
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open(FileName,FileMode.Append)))
            {
                foreach(var book in books)
                {
                    writer.Write(book.Author);
                    writer.Write(book.Title);
                    writer.Write(book.ISBN);
                    writer.Write(book.Gerne);
                }
            }
        }
    }
}
