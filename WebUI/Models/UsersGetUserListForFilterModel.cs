using System;
using System.Collections.Generic;
using Core.Entities.Concrete;

namespace WebUI.Models
{
    public class UsersGetUserListForFilterModel
    {
        public UsersGetUserListForFilterModel()
        {
        }

        public List<User> Users { get; set; }
    }
}
