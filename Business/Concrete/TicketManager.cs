using System;
using System.Collections.Generic;
using System.Threading;
using Business.Abstract;
using Business.CCS.Concrete;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Logging;
using Core.Aspects.Autofac.Performance;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;

namespace Business.Concrete
{
    public class TicketManager : ITicketService
    {
        ITicketDal _ticketDal;

        public TicketManager(ITicketDal ticketDal)
        {
            _ticketDal = ticketDal;
        }

        //eğer çalışma 5 sn sürer ise
        [PerformanceAspect(interval: 5)]
        public IDataResult<List<Ticket>> GetAllTickets()
        {
            //Thread.Sleep(millisecondsTimeout: 5000);
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

        [CacheAspect(duration:10)]
        [LogAspect(typeof(FileLogger))]
        public IDataResult<List<Ticket>> GetTicketsByCreatedUserId(int createdUserId)
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t=> t.CreatedUserId == createdUserId));
        }

        public IDataResult<List<Ticket>> GetTicketsByLastWeek()
        {
            return new SuccessDataResult<List<Ticket>>(_ticketDal.GetAll(filter: t => t.CreatedDate > DateTime.Now.AddDays(-7)));
        }

        [ValidationAspect(typeof(TicketValidator), Priority = 1)]
        //içerisinde ıticketservice.get olan cachleri silecek
        [CacheRemoveAspect(pattern: "ITicketService.Get")]
        public IResult Add(Ticket ticket)
        {
            ticket.CreatedDate = DateTime.Now;
            
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


        [TransactionScopeAspect]
        public IResult TransactionalOperation(Ticket ticket)
        {
            //invocation dediği aşağıdaki kodlar
            _ticketDal.Update(ticket);
            _ticketDal.Add(ticket);
            return new SuccessResult(Messages.TicketUpdated);

       }
    }
}
