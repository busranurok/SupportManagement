using System;
using System.Collections.Generic;
using System.Linq;
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

        public List<Ticket> GetAllTicketsWithIncludes()
        {
            var context = new SupportManagementContext();
            return context.Tickets.Include(x => x.CreatedUser).ToList();
        }
    }
}
