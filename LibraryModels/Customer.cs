using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    public class Customer
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;


        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }
        public int CustomerID { get; set; }
    }
}
