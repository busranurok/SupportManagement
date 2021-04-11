using System;
using System.Collections.Generic;
using Core.Entities.Concrete;

namespace WebUI.Models
{
    public class UsersUserListViewModel
    {
        public UsersUserListViewModel()
        {
        }

        public List<User> Users{ get; set; }
    }
}
