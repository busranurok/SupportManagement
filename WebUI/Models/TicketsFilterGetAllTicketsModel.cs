using System;
namespace WebUI.Models
{
    public class TicketsFilterGetAllTicketsModel
    {
        public TicketsFilterGetAllTicketsModel()
        {
        }

        public string CreatedDate { get; set; }
        public int OwnerId { get; set; }
        public int CustomerId { get; set; }
        public int TicketStatusId { get; set; }
    }
}
