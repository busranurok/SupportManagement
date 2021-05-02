using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTicketDal : EfEntityRepositoryBase<Ticket, SupportManagementContext>, ITicketDal
    {
        public EfTicketDal()
        {
        }

        public List<Ticket> GetAllTicketsWithIncludes(Expression<Func<Ticket, bool>> filter=null)
        {
            var context = new SupportManagementContext();
            if (filter == null)
            {
                return context.Tickets.Include(x => x.CreatedUser).ToList();
            }

            return context.Tickets.Include(x => x.CreatedUser).Where(filter).ToList();
        }


        public Ticket GetTicketWithInclude(Expression<Func<Ticket, bool>> filter = null)
        {
            var context = new SupportManagementContext();
            if (filter == null)
            {
                return context.Tickets.Include(c => c.CreatedUser).Include(o => o.Owner).Include(ts => ts.TicketStatus).SingleOrDefault();
            }

            return context.Tickets.Include(c => c.CreatedUser).Include(o => o.Owner).Include(ts => ts.TicketStatus).Where(filter).SingleOrDefault();
        }

        public List<Ticket> GetTicketListByFilters(List<Expression<Func<Ticket, bool>>> filterList)
        {
            var context = new SupportManagementContext();
            IQueryable<Ticket> result = context.Tickets.Include(x=> x.CreatedUser).Where(x=> x.Id>0);

            foreach (var filter in filterList)
            {
                result = result.Where(filter);
            }

            return result.ToList();

        }

        public List<TicketMessage> GetMessagesForTicketDetail(int ticketId)
        {
            var context = new SupportManagementContext();
            return context.TicketMessages.Where(t=> t.TicketId == ticketId).ToList();
        }
    }
}
