using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : Controller
    {
        ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet("getalltickets")]
        public IActionResult GetAllTickets()
        {
            var result = _ticketService.GetAllTickets();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getticketsbycreateduserid")]
        public IActionResult GetTicketsByCreatedUserId(int createdUserId)
        {
            var result = _ticketService.GetTicketsByCreatedUserId(createdUserId);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int ticketId)
        {
            var result = _ticketService.GetById(ticketId);

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("add")]
        public IActionResult Add(AddTicketRequestModel ticketModel)
        {
            var ticket = new Ticket();
            ticket.Body = ticketModel.Body;
            ticket.CompletedDate = null;
            ticket.CreatedDate = DateTime.Now;
            ticket.CreatedUserId = ticketModel.CreatedUserId;
            ticket.OwnerId = null;
            ticket.Subject = ticketModel.Subject;
            ticket.TicketStatusId = 1;
            ticket.TicketTypeId = ticketModel.TicketTypeId;

            var result = _ticketService.Add(ticket);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }



        [HttpPost("update")]
        public IActionResult Update(UpdateTicketRequestModel ticketModel)
        {
            var ticket = new Ticket();
            ticket.Body = ticketModel.Body;
            ticket.CompletedDate = null;
            ticket.CreatedDate = DateTime.Now;
            ticket.CreatedUserId = ticketModel.CreatedUserId;
            ticket.OwnerId = null;
            ticket.Subject = ticketModel.Subject;
            ticket.TicketStatusId = 1;
            ticket.TicketTypeId = ticketModel.TicketTypeId;

            var result = _ticketService.Update(ticket);

            if (result.Success)
            {
                return Ok(result.Success);
            }

            return BadRequest(result.Message);
        }


        [HttpPost("delete")]
        public IActionResult Delete(DeleteTicketRequestModel ticketModel)
        {
            var ticket = new Ticket();
            ticket.Body = ticketModel.Body;
            ticket.CompletedDate = null;
            ticket.CreatedDate = DateTime.Now;
            ticket.CreatedUserId = ticketModel.CreatedUserId;
            ticket.OwnerId = null;
            ticket.Subject = ticketModel.Subject;
            ticket.TicketStatusId = 1;
            ticket.TicketTypeId = ticketModel.TicketTypeId;

            var result = _ticketService.Delete(ticket);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getopentickets")]
        public IActionResult GetOpenTickets()
        {
            var result = _ticketService.GetOpenTickets();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("getclosedtickets")]
        public IActionResult GetClosedTickets()
        {
            var result = _ticketService.GetClosedTickets();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        public IActionResult GetTicketsByLastWeek()
        {
            var result = _ticketService.GetTicketsByLastWeek();

            if (result.Success)
            {
                return Ok(result.Data);
            }

            return BadRequest(result.Message);
        }


        [HttpGet("transaction")]
        public IActionResult TransactionTest(Ticket ticket)
        {
            var result = _ticketService.TransactionalOperation(ticket);

            if (result.Success)
            {
                return Ok(result.Message);
            }

            return BadRequest(result.Message);
        }
    }
}
