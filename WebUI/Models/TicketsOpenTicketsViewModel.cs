using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsOpenTicketsViewModel
    {
        public TicketsOpenTicketsViewModel()
        {
        }

        public List<Ticket> OpenTickets { get; set; }
    }
}
