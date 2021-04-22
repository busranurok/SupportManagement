using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace WebUI.Models
{
    public class TicketsTicketStatusesModel
    {
        public TicketsTicketStatusesModel()
        {
        }

        public List<TicketStatus> TicketStatuses { get; set; }
    }
}
