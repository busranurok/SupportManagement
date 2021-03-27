using System;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfTicketMessageDal : EfEntityRepositoryBase<TicketMessage, SupportManagementContext>, ITicketMessageDal
    {
        public EfTicketMessageDal()
        {
        }
    }
}
