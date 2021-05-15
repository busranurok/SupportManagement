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
    public class TicketMessageManager : ITicketMessageService
    {
        ITicketMessageDal _ticketMessageDal;

        public TicketMessageManager(ITicketMessageDal ticketMessageDal)
        {
            _ticketMessageDal = ticketMessageDal;
        }

        public IResult Add(TicketMessage message)
        {
            _ticketMessageDal.Add(message);
            return new SuccessResult(Messages.MessageAdded);
        }

        public IResult Delete(TicketMessage message)
        {
            _ticketMessageDal.Delete(message);
            return new SuccessResult(Messages.MessageDeleted);
        }

        public IDataResult<List<TicketMessage>> GetAllTicketMessages()
        {
            return new SuccessDataResult<List<TicketMessage>>(_ticketMessageDal.GetAll(filter: null));
        }

        public IDataResult<TicketMessage> GetById(int messageId)
        {
            return new SuccessDataResult<TicketMessage>(_ticketMessageDal.Get(filter: t => t.Id == messageId, true));

        }

            public IResult Update(TicketMessage message)
        {
            _ticketMessageDal.Update(message);
            return new SuccessResult(Messages.MessageUpdated);
        }
    }
}
