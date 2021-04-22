 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class CustomersController : Controller
    {
        ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }


        // GET: /<controller>/
        public IActionResult CustomerList()
        {
            CustomersCustomerListViewModel model = new CustomersCustomerListViewModel();
            model.Customers = _customerService.GetAllCustomers().Data;
            return View(model);
        }


        [HttpGet]
        public IActionResult CustomersGetCustomerListForFilter()
        {
            var customerList = _customerService.GetAllCustomers().Data;
            var data = new CustomersGetCustomerListForFilterModel();
            data.Customers = customerList;

            return Json(data);
        }


        public IActionResult CustomerDetail()
        {
            return View();
        }

        public IActionResult CustomerEdit()
        {
            return View();
        }


        public IActionResult CustomerDelete()
        {
            return View();
        }
    }
}
