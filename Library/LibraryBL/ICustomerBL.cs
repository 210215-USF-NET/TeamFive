using Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryBL
{
    interface ICustomerBL
    {
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer newCustomer);
        Customer GetCustomerByTitle(string title);
        Customer DeleteCustomer(Customer customer2BDeleted);
        Customer UpdateCustomer(Customer customer2BUpdated);
    }
}
