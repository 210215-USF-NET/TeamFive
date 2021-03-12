using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Models
{
    /// <summary>
    /// this models a book and how many available (quantity).
    /// the quantity is separated from the book because it could vary from 
    /// the amount of people that have it checked out
    /// </summary>
    public class Checkout
    {
        private string checkOutDate;
        private string dueDate;

        public string CheckOutDate { get; set; }
        public string DueDate { get; set; }
        public int Quantity { get; set; }
        public Book Book { get; set; }

   
        public Customer Customer { get; set; }

    }
}
