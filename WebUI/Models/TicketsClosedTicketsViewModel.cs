using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsClosedTicketsViewModel
    {
        public TicketsClosedTicketsViewModel()
        {
        }

        public List<Ticket> ClosedTickets { get; set; }
    }
}
