using LibraryDL;
using LibraryModels;
using System;
using System.Collections.Generic;
using System.Text;


namespace LibraryBL
{
    public class AuthorBL : IAuthorBL
    {
        private IAuthorRepository _repo;
        public AuthorBL(IAuthorRepository repo)
        {
            _repo = repo;
        }
        public Author AddAuthor(Author newAuthor)
        {
            return _repo.AddAuthor(newAuthor);
        }

        public List<Author> GetAuthors()
        {
            return _repo.GetAuthors();
        }

        public List<Author> GetAuthorsByName(string name)
        {
            return _repo.GetAuthorsByName(name);
        }

        //List<Author> IAuthorBL.GetAuthors()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
