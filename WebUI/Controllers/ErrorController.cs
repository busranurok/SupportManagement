using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /<controller>/
        public IActionResult Error(ErrorViewModel model)
        {
            return View(model);
        }
    }
}
