using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class TicketImages : IEntity
    {
        public TicketImages()
        {
        }

        public int Id { get; set; }
        public string ImagePath { get; set; }
        public object MyProperty { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TicketId { get; set; }
    }
}
