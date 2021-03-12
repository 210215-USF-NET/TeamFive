using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace LibraryModels
{
    public class Student : IdentityUser
    {
        /// <summary>
        /// To get student information
        /// </summary>
        [ProtectedPersonalData]
        [RegularExpression("[UIA]\\d{9}")]
        [Display(Name = "StudentID")]
        public override string UserName { get; set; }

        [Display(Name = "PhoneNumber")]
        [StringLength(10, MinimumLength = 10)]
        public override string PhoneNumber { get; set; }

        [Display(Name = "Name")]
        public string Name { get; set; }
    }
}