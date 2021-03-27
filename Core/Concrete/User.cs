using System;
using Core.Entities;

namespace Core.Entities.Concrete
{
    public class User : IEntity
    {
        public User()
        {
        }

        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsActive { get; set; }
        public bool IsAdmin { get; set; }

    }
}
