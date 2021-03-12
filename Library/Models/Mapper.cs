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
            throw new NotImplementedException();
        }

        public Book cast2Book(BookEditVM book2bCasted)
        {
            throw new NotImplementedException();
        }

        public BookCRVM cast2BookCRVM(Book Book)
        {
            throw new NotImplementedException();
        }

        public BookEditVM cast2BookEditVM(Book Book)
        {
            throw new NotImplementedException();
        }

        public BookIndexVM cast2BookIndexVM(Book book2BCasted)
        {
            throw new NotImplementedException();
        }
    }
}
