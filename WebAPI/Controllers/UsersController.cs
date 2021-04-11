using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Entities.Concrete;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpGet("getbyid")]
        public IActionResult GetById(int user)
        {
            var result = _userService.GetById(user);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getallusers")]
        public IActionResult GetAllUsers()
        {
            var result = _userService.GetAllUsers();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getuserbyemail")]
        public IActionResult GetUserByEmail(string email)
        {
            var result = _userService.GetUserByEmail(email);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }


        //[HttpPost("getuserbyemailandpassword")]
        [HttpPost("Login")]
        public IActionResult GetUserByEmailAndPassword(LoginRequestModel model)
        {
            var result = _userService.GetUserByEmailAndPassword(model.Email, null);
            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(User user)
        {
            var result = _userService.Add(user);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }

        [HttpPost("delete")]
        public IActionResult Delete(User user)
        {
            var result = _userService.Delete(user);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("update")]
        public IActionResult Update(User user)
        {
            var result = _userService.Update(user);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
