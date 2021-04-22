using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsGetAllTicketsViewModel
    {
        public TicketsGetAllTicketsViewModel()
        {
        }

        public List<Ticket> Tickets { get; set; }
    }
}
