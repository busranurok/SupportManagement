using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TicketStatusManager : ITicketStatusService
    {
        ITicketStatusDal _ticketStatusDal;

        public TicketStatusManager(ITicketStatusDal ticketStatusDal)
        {
            _ticketStatusDal = ticketStatusDal;
        }

        public IResult Add(TicketStatus ticketStatus)
        {
            _ticketStatusDal.Add(ticketStatus);
            return new SuccessResult(Messages.TicketStatusAdd);
        }

        public IResult Delete(TicketStatus ticketStatus)
        {
            _ticketStatusDal.Delete(ticketStatus);
            return new SuccessResult(Messages.TicketStatusDeleted);
        }

        public IDataResult<List<TicketStatus>> GetAllTicketStatuses()
        {
            return new SuccessDataResult<List<TicketStatus>>(_ticketStatusDal.GetAll());
        }

        public IDataResult<TicketStatus> GetById(int ticketStatusId)
        {
            return new SuccessDataResult<TicketStatus>(_ticketStatusDal.Get(filter: t=> t.Id == ticketStatusId,true));
        }

        public IResult Update(TicketStatus ticketStatus)
        {
            _ticketStatusDal.Update(ticketStatus);
            return new SuccessResult(Messages.TicketStatusUpdated);
        }
    }
}
