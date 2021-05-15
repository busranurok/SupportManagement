using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
using Microsoft.AspNetCore.Http;
using Core.Utilities.Hashing;
using Entities.DTOs;
using Core.Entities.Concrete;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class UsersController : Controller
    {
        IUserService _userService;
        IAuthService _authService;
        ICustomerService _customerService;

        public UsersController(IUserService userService, IAuthService authService, ICustomerService customerService)
        {
            _userService = userService;
            _authService = authService;
            _customerService = customerService;
        }


        public IActionResult UserList()
        {
            UsersUserListViewModel model = new UsersUserListViewModel();
            model.Users = _userService.GetAllUsers().Data;
            return View(model);
        }


        [HttpGet]
        public IActionResult UsersGetUserListForFilter()
        {
            var userList = _userService.GetAllUsers().Data;
            var data = new UsersGetUserListForFilterModel();
            data.Users = userList;

            return Json(data);
        }

        public IActionResult UserDetail(int userId)
        {
            var user  = _userService.GetById(userId);
            var model = new UsersUserDetailViewModel();
            model.User = user.Data;
            if (user.Data.CustomerId > 0)
            {
                var customer = _customerService.GetById(user.Data.CustomerId);
                model.CustomerName = customer.Data.Title;
            }
            return View(model);
        }


        public IActionResult UserEdit()
        {
            var customers = _customerService.GetAllCustomers();
            ViewBag.Customers = customers.Data;
            return View();
        }

        [HttpPost]
        public IActionResult UserEdit(UsersUserEditViewModel model)
        {
            var user = _userService.GetById(model.Id);
            user.Data.Email = model.Email;
            user.Data.IsActive = model.IsActive;
            user.Data.IsAdmin = model.IsAdmin;
            user.Data.LastName = model.LastName;
            user.Data.Name = model.Name;
            user.Data.CustomerId = model.CustomerId;

            _userService.Update(user.Data);

            return RedirectToAction("UserList");
        }

        public IActionResult UserInsert()
        {
            var customers = _customerService.GetAllCustomers();
            ViewBag.Customers = customers.Data;
            return View();
        }

        [HttpPost]
        public IActionResult UserInsert(UsersUserInsertViewModel model)
        {
            var userForRegisterDto = new UserForRegisterDto();
            userForRegisterDto.Email = model.Email;
            userForRegisterDto.LastName = model.LastName;
            userForRegisterDto.Name = model.Name;
            userForRegisterDto.Password = model.Password;
            _authService.Register(userForRegisterDto);
            return View();
        }

        public IActionResult UserDelete(int userId)
        {
            var user = _userService.GetById(userId);
            _userService.Delete(user.Data);
            return RedirectToAction("UserList");
        }



        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {

            var user = _authService.Login(new UserForLoginDto() { Email = model.UserName, Password = model.Password });
            var fullname = user.Data.Name + " " + user.Data.LastName;
            HttpContext.Session.SetInt32("UserId", user.Data.Id);
            HttpContext.Session.SetString("FullName", fullname);

            if (!user.Success)
            {
               
                return RedirectToAction("Error", "Error", new { Message = user.Message, RequestId= "LoginRequest", ErrorCode= "LoginRequest" });
            }

            return RedirectToAction("Index", "Home");

        }

        public IActionResult Profile()
        {
            var id = HttpContext.Session.GetInt32("UserId").Value;
            return RedirectToAction("UserDetail", new { userId = id});
        }

        public IActionResult Exit()
        {
            HttpContext.Session.SetInt32("UserId", 0);
            return RedirectToAction("Login");
        }
    }
}
