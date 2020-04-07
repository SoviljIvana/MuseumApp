using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.API.Models;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;

        public TicketsController(ITicketService ticketService)
        {
            _ticketService = ticketService;

        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketDomainModel>>> GetAllTickets()
        {
            IEnumerable<TicketDomainModel> ticketDomainModel = await _ticketService.GetAllTickets();
            if(ticketDomainModel == null)
            {
                return NotFound();
            }
            return Ok(ticketDomainModel);
        }

        [Route("get/{id}")]
        [HttpGet]
        public Task<ActionResult<TicketDomainModel>> GetTicketById(int id)
        {
            throw new NotImplementedException();
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public Task<ActionResult> DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<TicketDomainModel>> PostTicket(CreateTicketModel createTicket)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutTicket(int id, [FromBody]UpdateTicketModel updateTicket)
        {
            throw new NotImplementedException();
        }
    }
}