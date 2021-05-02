using System;
using System.Collections.Generic;
using System.Linq.Expressions;
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
        IDataResult<List<Ticket>> GetTicketByFilters(List<Expression<Func<Ticket, bool>>> filterList);
        IDataResult<Ticket> GetTicketWithInclude(Expression<Func<Ticket, bool>> filter = null);
        IDataResult<List<TicketMessage>> GetMessagesForTicketDetail(int ticketId);


        //transaction testi
        IResult TransactionalOperation(Ticket ticket);
    }
}
