using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Repositories;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketsRepository _ticketRepository;

        public TicketService(ITicketsRepository ticketRepository)
        {
            _ticketRepository = ticketRepository;
        }
    }
}
