using Library.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryModels
{
    public class Author
    {
        private int authorID;
        private string authorFName;
        private string authorLname;

        public Book Book { get; set; }

        public static int bookCount = 0;


    }
}
