using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Mapper : IMapper
    {
        public Book cast2Book(BookCRVM book2BCasted)
        {
            return new Book
            {
                BookName = book2BCasted.BookName,
                BookID = book2BCasted.BookID,
                Author = book2BCasted.Author,
                IsAvailable = book2BCasted.IsAvailable
            };
        }

        public Book cast2Book(BookEditVM book2bCasted)
        {
            throw new NotImplementedException();
        }

        public BookCRVM cast2BookCRVM(Book book)
        {
            return new BookCRVM
            {
                BookName = book.BookName,
                BookID = book.BookID,
                Author = book.Author,
                IsAvailable = book.IsAvailable
            };
        }

        public BookEditVM cast2BookEditVM(Book Book)
        {
            throw new NotImplementedException();
        }

        public BookIndexVM cast2BookIndexVM(Book book2BCasted)
        {
            return new BookIndexVM
            {
                BookName = book2BCasted.BookName,
                BookID = book2BCasted.BookID,
                Author = book2BCasted.Author,
                IsAvailable = book2BCasted.IsAvailable
            };
        }
    }
}
