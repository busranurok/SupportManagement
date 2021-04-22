using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITicketStatusService
    {
        IDataResult<TicketStatus> GetById(int ticketStatusId);
        IDataResult<List<TicketStatus>> GetAllTicketStatuses();
        IResult Add(TicketStatus ticketStatus);
        IResult Update(TicketStatus ticketStatus);
        IResult Delete(TicketStatus ticketStatus);
    }
}
