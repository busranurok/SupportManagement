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

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class UsersController : Controller
    {
        IUserService _userService;
        IAuthService _authService;

        public UsersController(IUserService userService, IAuthService authService)
        {
            _userService = userService;
            _authService = authService;
        }


        public IActionResult UserList()
        {
            return View();
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

            if (!user.Success)
            {
               
                return RedirectToAction("Error", "Error", new { Message = user.Message, RequestId= "LoginRequest", ErrorCode= "LoginRequest" });
            }

            return RedirectToAction("Index", "Home");

        }
    }
}
