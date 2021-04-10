using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITicketService
    {
        IDataResult<Ticket> GetById(int ticketId);
        IDataResult<List<Ticket>> GetAllTickets();
        //void Insert(Ticket ticket);
        IResult Add(Ticket ticket);
        IResult Update(Ticket ticket);
        IResult Delete(Ticket ticket);
        IDataResult<List<Ticket>> GetTicketsByCreatedUserId(int createdUserId);
        IDataResult<List<Ticket>> GetOpenTickets(int ticketStatusId = 1);
        IDataResult<List<Ticket>> GetClosedTickets(int ticketStatusId = 3);
        IDataResult<List<Ticket>> GetTicketsByLastWeek();


        //transaction testi
        IResult TransactionalOperation(Ticket ticket);
    }
}
