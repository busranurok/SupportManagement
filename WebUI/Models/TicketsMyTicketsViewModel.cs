using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsMyTicketsViewModel
    {
        public TicketsMyTicketsViewModel()
        {
        }

        public List<Ticket> MyTickets { get; set; }
    }
}
