using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITicketImageService
    {
        IDataResult<TicketImages> GetById(int imageId);
        IDataResult<List<TicketImages>> GetAllTicketImages();
        IResult Add(TicketImages image);
        IResult Update(TicketImages image);
        IResult Delete(TicketImages image);
    }
}
