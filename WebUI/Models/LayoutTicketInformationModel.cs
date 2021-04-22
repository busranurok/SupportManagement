using System;
namespace WebUI.Models
{
    public class LayoutTicketInformationModel
    {
        public LayoutTicketInformationModel()
        {
        }

        public int AllTicketCount { get; set; }
        public int OpenTicketCount { get; set; }
        public int MyTicketCount { get; set; }
    }
}
