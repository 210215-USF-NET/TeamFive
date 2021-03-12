using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public interface IMapper
    {
        Book cast2Book(BookCRVM book2BCasted);
        BookIndexVM cast2BookIndexVM(Book book2BCasted);
        BookCRVM cast2BookCRVM(Book Book);
        BookEditVM cast2BookEditVM(Book Book);
        Book cast2Book(BookEditVM book2bCasted);
    }
}
