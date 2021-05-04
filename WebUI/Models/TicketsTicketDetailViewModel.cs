using System;
using System.Collections.Generic;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace WebUI.Models
{
    public class TicketsTicketDetailViewModel
    {
        public TicketsTicketDetailViewModel()
        {
        }

        public Ticket Ticket { get; set; }
        public List<TicketMessage> TicketMessages { get; set; }

        public string SendMessage { get; set; }
        public List<IFormFile> Files { get; set; }

    }
}
