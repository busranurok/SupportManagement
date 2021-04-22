using System;
namespace WebAPI.Models
{
    public class UpdateTicketRequestModel
    {
        public UpdateTicketRequestModel()
        {
        }

        public string Subject { get; set; }
        public string Body { get; set; }
        public int CreatedUserId { get; set; }
        public int TicketTypeId { get; set; }
    }
}
