 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
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


        public IActionResult CustomerDetail(int customerId)
        {
            var customer = _customerService.GetById(customerId);
            var model = new CustomersCustomerDetailViewModel();
            model.Customer = customer.Data;

            return View(model);
        }

        //ekranı göstermek
        [HttpGet]
        public IActionResult CustomerInsert()
        {
            return View();
        }

        //ekrandaki veriyi almak için
        public IActionResult CustomerInsert(CustomersCustomerInsertViewModel model)
        {
            var customer = new Customer();
            customer = model.Customer;
            _customerService.Add(customer);
            //aynı controller içerisinde olduğum için controller parametresini vermeme gerek yok
            return RedirectToAction("GetAllCustomers", "Customers");

        }


        [HttpGet]
        public IActionResult CustomerEdit(int customerId)
        {
            var customer =_customerService.GetById(customerId).Data;
            var model = new CustomersCustomerEditViewModel();
            model.Customer = customer;
            return View(model);
        }

        [HttpPost]
        public IActionResult CustomerEdit(CustomersCustomerEditViewModel model)
        {
            _customerService.Update(model.Customer);
            return RedirectToAction("CustomerList");
        }

       

        public IActionResult CustomerDelete(int customerId)
        {
            var customer = _customerService.GetById(customerId);
            _customerService.Delete(customer.Data);
            return RedirectToAction("CustomerList");
        }
    }
}
