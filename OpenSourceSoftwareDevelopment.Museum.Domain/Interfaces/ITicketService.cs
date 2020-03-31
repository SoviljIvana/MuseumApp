using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface ITicketService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<TicketDomainModel>> GetAllTickets();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TicketDomainModel> GetTicketByIdAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<TicketDomainModel> CreateTicket();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TicketDomainModel> DeleteTicket(int id);
        
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<TicketDomainModel> UpdateTicket();
    }
}
