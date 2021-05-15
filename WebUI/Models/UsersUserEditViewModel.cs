using System;
using Core.Entities.Concrete;

namespace WebUI.Models
{
    public class UsersUserEditViewModel
    {
        public UsersUserEditViewModel()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public bool IsActive { get; set; }
        public int CustomerId { get; set; }

    }
}
