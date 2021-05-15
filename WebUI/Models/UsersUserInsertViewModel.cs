using System;
namespace WebUI.Models
{
    public class UsersUserInsertViewModel
    {
        public UsersUserInsertViewModel()
        {
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }
    }
}
