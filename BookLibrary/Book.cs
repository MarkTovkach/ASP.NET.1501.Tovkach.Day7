using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary
{
    public class Book :  IEquatable<Book>, IComparable<Book>
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public uint ISBN { get; set; } 
        public string  Gerne { get; set; }


        public bool Equals(Book someBook)
        {
            if (someBook == null)
            {
                return false;
            }
            if (Author == someBook.Author && Title == someBook.Title )
            {
                return true;
            }
            return false;
        }

        public int CompareTo(Book book)
        {
            if (book == null) 
                return 1;
            if (this.ISBN > book.ISBN) 
                return 1;
            if (this.ISBN < book.ISBN)
                return -1;
            else return 0;

        }

        public override bool Equals(object obj)
        {
            if (!(obj is Book)) return false;
            return Equals((Book)obj);
        }

        public override int GetHashCode()
        {
            return (Author + Title).GetHashCode() ^ (Gerne + ISBN.ToString()).GetHashCode();
        }

        public override string ToString()
        {
            return "Author:" + Author + " Title:" + Title + " ISBN:" + ISBN + " Gerne:" + Gerne;
        }




    }
}
