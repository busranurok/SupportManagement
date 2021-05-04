using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using WebUI.Models;
using Entities.Concrete;
using System.Linq.Expressions;
using System.IO;

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
            model.MyTickets = tickets.Data;
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
            var model = new TicketsGetAllTicketsViewModel();
            model.Tickets = ticketList.Data;
            return View(model);
        }


        [HttpGet]
        public IActionResult GetSummaryInformation()
        {
            var data = new LayoutTicketInformationModel();
            data.AllTicketCount = 11;
            data.MyTicketCount = 22;
            data.OpenTicketCount = 66;

            return Json(data);
        }

        [HttpPost]
        public IActionResult FilterMyTickets(TicketsFilterMyTicketsModel model)
        {
            List<Expression<Func<Ticket, bool>>> filterList = new List<Expression<Func<Ticket, bool>>>();

            if (model.CustomerId!=0)
            {
                filterList.Add(x => x.CustomerId == model.CustomerId);
            }

            if (model.OwnerId!=0)
            {
                filterList.Add(x => x.OwnerId == model.OwnerId);
            }

            switch (model.CreatedDate)
            {
                case "thisWeek":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddDays(-7));
                    break;
                case "thisMonth":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-1));
                    break;
                case "lastThreeMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-3));
                    break;
                case "lastSixMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-6));
                    break;
                case "lastYear":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddYears(-1));
                    break;
                default:
                    break;
            }

            var ticketList= _ticketService.GetTicketByFilters(filterList);
            return Json(ticketList.Data);
        }


        [HttpPost]
        public IActionResult FilterOpenTickets(TicketsFilterOpenTicketsModel model)
        {
            List<Expression<Func<Ticket, bool>>> filterList = new List<Expression<Func<Ticket, bool>>>();

            if (model.CustomerId != 0)
            {
                filterList.Add(x => x.CustomerId == model.CustomerId);
            }

            if (model.OwnerId != 0)
            {
                filterList.Add(x => x.OwnerId == model.OwnerId);
            }

            switch (model.CreatedDate)
            {
                case "thisWeek":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddDays(-7));
                    break;
                case "thisMonth":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-1));
                    break;
                case "lastThreeMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-3));
                    break;
                case "lastSixMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-6));
                    break;
                case "lastYear":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddYears(-1));
                    break;
                default:
                    break;
            }

            var ticketList = _ticketService.GetTicketByFilters(filterList);
            return Json(ticketList.Data);
        }


        [HttpPost]
        public IActionResult FilterGetAllTickets(TicketsFilterGetAllTicketsModel model)
        {
            List<Expression<Func<Ticket, bool>>> filterList = new List<Expression<Func<Ticket, bool>>>();

            if (model.CustomerId != 0)
            {
                filterList.Add(x => x.CustomerId == model.CustomerId);
            }

            if (model.OwnerId != 0)
            {
                filterList.Add(x => x.OwnerId == model.OwnerId);
            }

            if (model.TicketStatusId != 0)
            {
                filterList.Add(x => x.TicketStatusId == model.TicketStatusId);
            }

            switch (model.CreatedDate)
            {
                case "thisWeek":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddDays(-7));
                    break;
                case "thisMonth":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-1));
                    break;
                case "lastThreeMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-3));
                    break;
                case "lastSixMonths":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddMonths(-6));
                    break;
                case "lastYear":
                    filterList.Add(x => x.CreatedDate > DateTime.Now.AddYears(-1));
                    break;
                default:
                    break;
            }

            var ticketList = _ticketService.GetTicketByFilters(filterList);
            return Json(ticketList.Data);
        }


        public IActionResult TicketDetail(int ticketId)
        {
            var ticket = _ticketService.GetTicketWithInclude(t => t.Id == ticketId);
            var model = new TicketsTicketDetailViewModel();
            model.Ticket = ticket.Data;

            var ticketMessageList = _ticketService.GetMessagesForTicketDetail(ticketId);
            model.TicketMessages = ticketMessageList.Data;
            return View(model);
        }

        [HttpPost]
        public IActionResult Send(TicketsTicketDetailViewModel model)
        {
            if (model.Files == null || model.Files.Count == 0)
                return Content("Dosya(lar) seçilmedi.");

            foreach (var formFile in model.Files)
            {
                if (formFile.Length > 0)
                {
                    // full path to file in temp location
                    var fileNameWithPath = "/Users/hbo/Desktop/netProjects/SupportManagement/WebUI/bin/Debug/netcoreapp3.1/wwwroot/images/"+formFile.FileName;

                    using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
                    {
                        formFile.CopyTo(stream);
                    }
                }

            }


            return RedirectToAction("GetAllTickets");
        }

    }
}
