using System;
using Core.Entities;

namespace Entities.Concrete
{
    public class TicketStatus : IEntity
    {
        public TicketStatus()
        {
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
