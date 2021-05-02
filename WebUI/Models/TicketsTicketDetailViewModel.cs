using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsTicketDetailViewModel
    {
        public TicketsTicketDetailViewModel()
        {
        }

        public Ticket Ticket { get; set; }
        public List<TicketMessage> TicketMessages { get; set; }
    }
}
