using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class TicketStatusesController : Controller
    {
        ITicketStatusService _ticketStatusService;

        public TicketStatusesController(ITicketStatusService ticketStatusService)
        {
            _ticketStatusService = ticketStatusService;
        }

        public IActionResult GetAllTicketStatuses()
        {
            var ticketStatusList = _ticketStatusService.GetAllTicketStatuses();
            var model = new TicketsTicketStatusesModel();
            model.TicketStatuses = ticketStatusList.Data;
            return View(model);
        }


        [HttpGet]
        public IActionResult TicketStatusGetTicketStatusListForFilter()
        {
            var ticketStatusList = _ticketStatusService.GetAllTicketStatuses().Data;
            var data = new TicketsTicketStatusesModel();
            data.TicketStatuses = ticketStatusList;

            return Json(data);
        }
    }
}
