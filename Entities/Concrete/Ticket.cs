using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Core.Entities;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Http;

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
        [ForeignKey("CreatedUserId")]
        public virtual User CreatedUser { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketStatusId { get; set; }
        [ForeignKey("TicketStatusId")]
        public virtual TicketStatus TicketStatus{ get; set; }
        public int? OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int CustomerId { get; set; }
        public List<TicketImages> Images { get; set; }
        
    }
}
