using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface ITicketsRepository : IRepository<TicketEntity>
    {

    }
    public class TicketsRepository : ITicketsRepository
    {
        private readonly MuseumContext _museumContext;

        public TicketsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public TicketEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TicketEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TicketEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public TicketEntity Insert(TicketEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public TicketEntity Update(TicketEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
