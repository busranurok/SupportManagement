using System;
using System.Collections.Generic;
using Business.Abstract;
using Core.Utilities.Results.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TicketTypeManager : ITicketTypeService
    {
        ITicketTypeDal _ticketTypeDal;

        public TicketTypeManager(ITicketTypeDal ticketTypeDal)
        {
            _ticketTypeDal = ticketTypeDal;
        }

    }
}
