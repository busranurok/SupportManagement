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

        //ticket detayını ekrana basmak için bbu verilere ihtiyac duyarz.
        public Ticket Ticket { get; set; }
        public List<TicketMessage> TicketMessages { get; set; }
        //ticket mesagesi gönderildiğinde suucuya göndermek istediğimiz veriler bunkardır!
        public string SendMessage { get; set; }
        public List<IFormFile> Files { get; set; }
        public int TicketId { get; set; }
        public int TicketState { get; set; }

    }
}
