using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class TicketAttachement : IEntity
    {
        public TicketAttachement()
        {
        }

        public int Id { get; set; }
        public int TicketMessageId { get; set; }
        public string Path { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
