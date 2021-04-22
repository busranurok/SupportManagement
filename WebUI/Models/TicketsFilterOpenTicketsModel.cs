using System;
namespace WebUI.Models
{
    public class TicketsFilterOpenTicketsModel
    {
        public TicketsFilterOpenTicketsModel()
        {
        }

        public string CreatedDate { get; set; }
        public int OwnerId { get; set; }
        public int CustomerId { get; set; }
    }
}
