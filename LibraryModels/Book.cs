using LibraryModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Book
    {
        private string bookName;
        private int bookID;
        private bool isAvailable;

        


        public string BookName { get; set; }
        public int BookID { get; set; }
        public Author Author { get; set; }

        public bool IsAvailable {get;set;}
        

    }
}
