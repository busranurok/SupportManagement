using System;
namespace WebUI.Models
{
    public class TicketsInsertViewModel
    {
        public TicketsInsertViewModel()
        {
        }

        public int TicketTypeId { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
