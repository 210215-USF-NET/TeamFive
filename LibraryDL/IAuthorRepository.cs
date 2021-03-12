using LibraryModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryDL
{
    public interface IAuthorRepository
    {
        List<Author> GetAuthors();
        Author AddAuthor(Author newAuthor);
        List<Author> GetAuthorsByName(string name);
    }
}
