using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.API.Models;
using OpenSourceSoftwareDevelopment.Museum.Domain.Common;
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
                return NotFound(Messages.TICKET_GET_ALL_ERROR);
            }
            return Ok(ticketDomainModel);
        }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<TicketDomainModel>> GetTicketById(int id)
        {
            TicketDomainModel ticketDomainModel = await _ticketService.GetTicketByIdAsync(id);

            if (ticketDomainModel == null)
            {
                return NotFound(Messages.TICKET_GET_ID_ERROR + id);
            }

            return Ok(ticketDomainModel);
        }
    }
}