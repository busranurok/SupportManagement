using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Customer : IEntity
    {
        public Customer()
        {
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string TaxNo { get; set; }
        public string Address { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
