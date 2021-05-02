using System;
using System.Collections.Generic;
using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface ITicketDal : IEntityRepository<Ticket>
    {

        List<Ticket> GetAllTicketsWithIncludes(Expression<Func<Ticket, bool>> filter=null);
        List<Ticket> GetTicketListByFilters(List<Expression<Func<Ticket, bool>>> filterList);
        Ticket GetTicketWithInclude(Expression<Func<Ticket, bool>> filter = null);
        List<TicketMessage> GetMessagesForTicketDetail(int ticketId);

    }
}
