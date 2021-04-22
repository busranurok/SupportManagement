using System;
namespace WebUI.Models
{
    public class TicketsFilterMyTicketsModel
    {
        public TicketsFilterMyTicketsModel()
        {
        }

        public string CreatedDate { get; set; }
        public int OwnerId { get; set; }
        public int CustomerId { get; set; }
    }
}
