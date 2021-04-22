using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class CustomersGetCustomerListForFilterModel
    {
        public CustomersGetCustomerListForFilterModel()
        {
        }

        public List<Customer> Customers { get; set; }
    }
}
