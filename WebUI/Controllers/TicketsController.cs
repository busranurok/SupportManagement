using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebUI.Models;
using Entities.Concrete;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebUI.Controllers
{
    public class TicketsController : Controller
    {
        ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        // GET: /<controller>/
        public IActionResult MyTickets()
        {
            var userId = HttpContext.Session.GetInt32("UserId");
            var tickets = _ticketService.GetTicketsByCreatedUserId(userId.Value);
            var model = new TicketsMyTicketsViewModel();
            model.Tickets = tickets.Data;
            return View(model);
        }

        public IActionResult OpenTickets()
        {
            var openTickets= _ticketService.GetOpenTickets();
            var model = new TicketsOpenTicketsViewModel();
            model.OpenTickets = openTickets.Data;
            return View(model);
        }

        public IActionResult ClosedTickets()
        {
            var closedTickets = _ticketService.GetClosedTickets();
            var model = new TicketsClosedTicketsViewModel();
            model.ClosedTickets = closedTickets.Data;
            return View(model);
        }

        public IActionResult GetTicketsByLastWeek()
        {
            var ticketsByLastWeek = _ticketService.GetTicketsByLastWeek();
            var model = new TicketsTicketsByLastWeekViewModel();
            model.TicketsByLastWeek = ticketsByLastWeek.Data;
            return View(model);
           
        }

        //ekranı göstermek
        [HttpGet]
        public IActionResult Insert()
        {
            return View();
        }

        //ekrandaki veriyi almak için
        public IActionResult Insert(TicketsInsertViewModel model)
        {
            var ticket = new Ticket();
            ticket.Body = model.Body;
            ticket.TicketTypeId = model.TicketTypeId;
            ticket.Subject = model.Subject;
            ticket.CompletedDate = null;
            ticket.CreatedDate = DateTime.Now;
            ticket.CreatedUserId = HttpContext.Session.GetInt32("UserId").Value;
            ticket.OwnerId = null;
            ticket.TicketStatusId = 1;
            ticket.TicketTypeId = 1;
            _ticketService.Add(ticket);
            //aynı controller içerisinde olduğum için controller parametresini vermeme gerek yok
            return RedirectToAction("GetAllTickets", "Tickets");

        }

        public IActionResult GetAllTickets()
        {
            var ticketList = _ticketService.GetAllTickets();
            return View(ticketList.Data);
        }
    }
}
