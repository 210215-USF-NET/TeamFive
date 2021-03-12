using Library.Models;
using StoreDL;
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
        public BookRepoDB(LibraryDBContext context)
        {
            _context = context;
        }
        public Book AddBook(Book newBook)
        {
            _context.Book.Add(newBook);
            _context.SaveChanges();
            return newBook;
        }

        public Book DeleteBook(Book book2BDeleted)
        {
            _context.Book.Remove(book2BDeleted);
            _context.SaveChanges();
            return book2BDeleted;
        }

        public Book GetBookByTitle(string title)
        {
            return _context.Book
                .FirstOrDefault(x => x.BookName == title);
        }

        public List<Book> GetBooks()
        {
            return _context.Book
                .Select(x => x)
                .ToList();
        }

        public Book UpdateBook(Book book2BUpdated)
        {
            Book oldBook = _context.Book.Find(book2BUpdated.BookID);


            _context.Entry(oldBook).CurrentValues.SetValues(book2BUpdated);

            _context.SaveChanges();

            //This method clears the change tracker to drop all tracked entities
            _context.ChangeTracker.Clear();
            return book2BUpdated;
        }
    }
}
