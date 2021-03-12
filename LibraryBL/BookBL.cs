using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library.Models;
using LibraryDL;
using LibraryModels;

namespace LibraryBL
{
    class BookBL : IBookBL
    {
        private IBookRepository _repo;

        public BookBL(IBookRepository repo)
        {
            _repo = repo;
        }
        public Book AddBook(Book newBook)
        {
            return _repo.AddBook(newBook);
        }

        public Book DeleteBook(Book book2BDeleted)
        {
            return _repo.DeleteBook(book2BDeleted);
        }

        public Book GetBookByTitle(string title)
        {
            return _repo.GetBookByTitle(title);
        }

        public List<Book> GetBooks()
        {
            return _repo.GetBooks();
        }

        public Book UpdateBook(Book book2BUpdated)
        {
            return _repo.UpdateBook(book2BUpdated);
        }
    }
}
