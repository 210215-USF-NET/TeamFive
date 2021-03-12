using LibraryModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryBL
{
    public interface IAuthorBL
    {
        List<Author> GetAuthors();
        Author AddAuthor(Author newAuthor);
        List<Author> GetAuthorsByName(string name);


    }
}
