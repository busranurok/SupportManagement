using System;
using System.Collections.Generic;
using Core.Utilities.Results.Abstract;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITicketImagesService
    {
        IDataResult<TicketImages> GetById(int ticketImageId);
        IDataResult<List<TicketImages>> GetAllTicketImages();
        IResult Add(TicketImages ticketImages);
        IResult Update(TicketImages ticketImages);
        IResult Delete(TicketImages ticketImages);
    }
}
