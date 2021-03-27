using System;
using Business.Abstract;
using DataAccess.Abstract;

namespace Business.Concrete
{
    public class TicketAttachementManager : ITicketAttachementService
    {
        ITicketAttachementDal _ticketAttachementDal;

        public TicketAttachementManager(ITicketAttachementDal ticketAttachementDal)
        {
            _ticketAttachementDal = ticketAttachementDal;
        }
    }
}
