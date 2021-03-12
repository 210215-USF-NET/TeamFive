using LibraryModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class BookCRVM
    {
        [DisplayName("Name")]
        [Required]
        public string BookName { get; set; }
        [DisplayName("ID")]
        [Required]
        public int BookID { get; set; }
        [DisplayName("Author")]
        [Required]
        public Author Author { get; set; }
        [DisplayName("Address")]
        [Required]
        public bool IsAvailable { get; set; }
    }
}
