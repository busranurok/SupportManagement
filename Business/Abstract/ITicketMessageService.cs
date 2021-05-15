using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITicketMessageService
    {
        IDataResult<TicketMessage> GetById(int messageId);
        IDataResult<List<TicketMessage>> GetAllTicketMessages();
        IResult Add(TicketMessage message);
        IResult Update(TicketMessage message);
        IResult Delete(TicketMessage message);
    }
}
