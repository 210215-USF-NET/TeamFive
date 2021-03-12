using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDL
{
    class BookRepoDB : IBookRepository
    {
        private readonly LibraryDBContext _context;
        public BookRepoDB(LibraryDBContext _context)
        {
            _context = context;
        }
        public Book AddBook(Book newBook)
        {
            _context.Books.Add(newBook);
            _context.SaveChanges();
            return newBook;
        }

        public Book DeleteBook(Book book2BDeleted)
        {
            _context.Books.Remove(book2BDeleted);
            _context.SaveChanges();
            return book2BDeleted;
        }

        public Book GetBookByTitle(string title)
        {
            return _context.Books
                .FirstOrDefault(x => x.BookTitle == title);
        }

        public List<Book> GetBooks()
        {
            return _context.Books
                .Select(x => x)
                .ToList();
        }

        public Book UpdateBook(Book book2BUpdated)
        {
            Book oldBook = _context.Books.Find(book2BUpdated.BookID);


            _context.Entry(oldBook).CurrentValues.SetValues(book2BUpdated);

            _context.SaveChanges();

            //This method clears the change tracker to drop all tracked entities
            _context.ChangeTracker.Clear();
            return book2BUpdated;
        }
    }
}
