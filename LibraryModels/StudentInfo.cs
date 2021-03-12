using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryModels
{
    public class StudentInfo
    {
        [Key]
        public string UserName { get; set; }

        [Required]
        public string Name { get; set; }

        [StringLength(10, MinimumLength = 10)]
        public string PhoneNumber { get; set; }

        public decimal Fine { get; set; }               
    }
}