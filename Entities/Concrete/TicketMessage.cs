using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class TicketMessage : IEntity
    {
        public TicketMessage()
        {
        }

        public int Id { get; set; }
        public int TicketId { get; set; }
        public int CreatedUserId { get; set; }
        public int TicketStatusId  { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
