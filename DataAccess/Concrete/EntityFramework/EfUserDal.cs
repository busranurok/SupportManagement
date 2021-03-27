using System;
using System.Linq;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Core.Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, SupportManagementContext>, IUserDal
    {
        //Burada iki tablonun join yapılması işlemleri gerçekleştirilir!
        //Mesela user ın customer bir şeyini getir. İkisinin idlerinin içerisinde bulunduğu başka tablo.

        //bunu da dto şeklinde yazabiliriz.
        public EfUserDal()
        {
        }
    }
}
