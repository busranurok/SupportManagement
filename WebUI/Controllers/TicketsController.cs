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
        ITicketImageService _ticketImageService;
        ITicketMessageService _ticketMessageService;

        public TicketsController(ITicketService ticketService, ITicketImageService ticketImageService, ITicketMessageService ticketMessageService)
        {
            _ticketService = ticketService;
            _ticketImageService = ticketImageService;
            _ticketMessageService = ticketMessageService;
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
            var currentUserId = HttpContext.Session.GetInt32("UserId").Value;
            var data = new LayoutTicketInformationModel();
            
            data.AllTicketCount = _ticketService.GetAllTickets().Data.Count(); ;
            data.MyTicketCount = _ticketService.GetTicketByFilters(new List<Expression<Func<Ticket, bool>>>() { x => x.OwnerId == currentUserId }).Data.Count();
            data.OpenTicketCount = _ticketService.GetTicketByFilters(new List<Expression<Func<Ticket, bool>>>() { x => x.TicketStatusId == 1 }).Data.Count();

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

                    #region Creating TicketImage
                    var ticketImage = new TicketImages();
                    ticketImage.CreatedDate = DateTime.Now;
                    ticketImage.ImageName = formFile.FileName;
                    ticketImage.ImagePath = fileNameWithPath;
                    ticketImage.TicketId = model.TicketId;
                    _ticketImageService.Add(ticketImage);
                    #endregion

                   
                }

            }

            #region Creating TicketMessage
            var ticketMessage = new TicketMessage();
            ticketMessage.Body = model.SendMessage;
            ticketMessage.CreatedDate = DateTime.Now;
            ticketMessage.CreatedUserId = HttpContext.Session.GetInt32("UserId").Value;
            ticketMessage.TicketId = model.TicketId;
            ticketMessage.TicketStatusId = model.TicketState;
            _ticketMessageService.Add(ticketMessage);
            #endregion

            return RedirectToAction("GetAllTickets");
        }

    }
}
