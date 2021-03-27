using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    //controller/action/viewmodel
    public class TicketsTicketsByLastWeekViewModel
    {
        public TicketsTicketsByLastWeekViewModel()
        {
        }

        public List<Ticket> TicketsByLastWeek { get; set; }
    }
}
