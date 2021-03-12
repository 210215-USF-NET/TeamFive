using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    public interface IBookBL
    {
        List<Book> GetBooks();
        Book AddBook(Book newBook);
        Book GetBookByTitle(string title);
        Book DeleteBook(Book book2BDeleted);
        Book UpdateBook(Book book2BUpdated);
    }
}
