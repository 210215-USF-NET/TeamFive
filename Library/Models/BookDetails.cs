using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Library.Models
{
	public class BookDetails
	{
        [Key]
        public string BookID { get; set; }
        [Display(Name = "BookName")]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Author")]
        [Required]
        public string Author { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        [Display(Name = "Available")]
        public bool IsAvailable { get; set; }
    }
}
