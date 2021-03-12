using LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookIndexVM
    {
        [DisplayName("Title")]
        public string BookName { get; set; }
        [DisplayName("ID")]
        public int BookID { get; set; }
        [DisplayName("Author")]
        public Author Author { get; set; }
        [DisplayName("Available")]
        public bool IsAvailable { get; set; }
    }
}
