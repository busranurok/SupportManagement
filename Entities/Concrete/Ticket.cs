using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class Ticket : IEntity
    {
        public Ticket()
        {
            this.CompletedDate = null;
            this.OwnerId = null;
        }

        public int Id { get; set; }
        public int CreatedUserId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketStatusId { get; set; }
        public int? OwnerId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
    }
}
