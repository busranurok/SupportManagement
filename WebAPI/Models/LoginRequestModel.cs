using System;
namespace WebAPI.Models
{
    public class LoginRequestModel
    {
        public LoginRequestModel()
        {
        }

        public string Email { get; set; }
        public string Password { get; set; }
    }
}
