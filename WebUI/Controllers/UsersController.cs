using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;
using Microsoft.AspNetCore.Http;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class UsersController : Controller
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = _userService.GetUserByEmailAndPassword(model.UserName, null);

            if (user.Data != null)
            {
                HttpContext.Session.SetString("UserName", user.Data.Email);
                HttpContext.Session.SetString("Name", user.Data.Name);
                HttpContext.Session.SetInt32("UserId", user.Data.Id);
                HttpContext.Session.SetInt32("IsAdmin", user.Data.IsAdmin == true? 1 : 0);
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View("Error", new ErrorViewModel()
                {

                    RequestId = "0",
                    Message = "Kullanıcı getirilirken hata oluştu."

                });
            }
            
        }

    }
}
