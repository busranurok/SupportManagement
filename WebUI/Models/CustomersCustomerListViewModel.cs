using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class CustomersCustomerListViewModel
    {
        public CustomersCustomerListViewModel()
        {
        }

        public List<Customer> Customers { get; set; }
    }
}
