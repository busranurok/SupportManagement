using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class TicketImagesManager : ITicketImagesService
    {
        ITicketImagesDal _ticketImagesDal;

        public TicketImagesManager(ITicketImagesDal ticketImages)
        {
            _ticketImagesDal = ticketImages;
        }

        public IResult Add(TicketImages ticketImages)
        {
            _ticketImagesDal.Add(ticketImages);
            return new SuccessResult(Messages.ticketImagesAdded);
        }

        public IResult Delete(TicketImages ticketImages)
        {
            _ticketImagesDal.Delete(ticketImages);
            return new SuccessResult(Messages.TicketImagesDeleted);
        }

        public IDataResult<List<TicketImages>> GetAllTicketImages()
        {
            return new SuccessDataResult<List<TicketImages>>(_ticketImagesDal.GetAll(filter: null));
        }

        public IDataResult<TicketImages> GetById(int ticketImageId)
        {
            return new SuccessDataResult<TicketImages>(_ticketImagesDal.Get(filter: t => t.Id == ticketImageId, true));
        }

        public IResult Update(TicketImages ticketImages)
        {
            _ticketImagesDal.Update(ticketImages);
            return new SuccessResult(Messages.TicketImagesUpdated);
        }
    }
}
