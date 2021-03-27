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
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        public IDataResult<List<Ticket>> GetAllTickets()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter : null));
        }

        public IDataResult<Ticket> GetById(int ticketId)
        {
            return new SuccessDataResult<Ticket>(_ticketDal.Get(filter: t=> t.Id == ticketId, true));
        }

        public IDataResult<List<Ticket>> GetClosedTickets(int ticketStatusId = 3)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t=> t.TicketStatusId == ticketStatusId));
        }

        public IDataResult<List<Ticket>> GetOpenTickets(int ticketStatusId = 1)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t=> t.TicketStatusId == ticketStatusId));
        }

        public IDataResult<List<Ticket>> GetTicketsByCreatedUserId(int createdUserId)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t=> t.CreatedUserId == createdUserId));
        }

        public IDataResult<List<Ticket>> GetTicketsByLastWeek()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t => t.CreatedDate > DateTime.Now.AddDays(-7)));
        }

        public IResult Add(Ticket ticket)
        {
            _ticketDal.Add(ticket);
            return new SuccessResult(Messages.TicketAdded);
        }

        public IResult Update(Ticket ticket)
        {
            _ticketDal.Update(ticket);
            return new SuccessResult(Messages.TicketUpdated);
        }

        public IResult Delete(Ticket ticket)
        {
            _ticketDal.Delete(ticket);
            return new SuccessResult(Messages.TicketDeleted);
        }
    }
}
