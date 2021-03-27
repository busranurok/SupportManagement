using System;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class TicketStatusManager : ITicketStatusService
    {
        ITicketStatusDal _ticketStatusDal;

        public TicketStatusManager(ITicketStatusDal ticketStatusDal)
        {
            _ticketStatusDal = ticketStatusDal;
        }
    }
}
