using System;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class TicketMessageManager : ITicketMessageService
    {
        ITicketMessageDal _ticketMessageDal;

        public TicketMessageManager(ITicketMessageDal ticketMessageDal)
        {
            _ticketMessageDal = ticketMessageDal;
        }
    }
}
