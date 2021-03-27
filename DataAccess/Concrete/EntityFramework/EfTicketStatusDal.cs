using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTicketStatusDal : EfEntityRepositoryBase<TicketStatus,SupportManagementContext>, ITicketStatusDal
    {
        public EfTicketStatusDal()
        {
        }
    }
}
