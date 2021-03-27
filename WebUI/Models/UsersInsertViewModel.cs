using System;
namespace WebUI.Models
{
    public class UsersInsertViewModel
    {
        public UsersInsertViewModel()
        {
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
