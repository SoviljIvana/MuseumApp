using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketsRepository _ticketRepository;

        public TicketService(ITicketsRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }

        public Task<TicketDomainModel> CreateTicket()
        {
            throw new System.NotImplementedException();
        }

        public Task<TicketResultModel> CreateTicket(TicketDomainModel ticketModel)
        {
            throw new System.NotImplementedException();
        }

        public Task<TicketDomainModel> DeleteTicket(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<TicketDomainModel>> GetAllTickets()
        {
            throw new System.NotImplementedException();
        }

        public Task<TicketDomainModel> GetTicketByIdAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<TicketDomainModel> UpdateTicket()
        {
            throw new System.NotImplementedException();
        }

        Task<TicketResultModel> ITicketService.DeleteTicket(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<TicketResultModel> ITicketService.UpdateTicket()
        {
            throw new System.NotImplementedException();
        }
    }
}
