using System;
using Core.Entities.Concrete;

namespace WebUI.Models
{
    public class UsersUserDetailViewModel
    {
        public UsersUserDetailViewModel()
        {
            this.CustomerName = "";
        }

        public User User { get; set; }
        public string CustomerName { get; set; }

    }
}
