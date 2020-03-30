using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface ITicketsRepository : IRepository<Ticket>
    {

    }
    public class TicketsRepository : ITicketsRepository
    {
        private readonly MuseumContext _museumContext;

        public TicketsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Ticket Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Ticket>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Ticket> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Ticket Insert(Ticket obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Ticket Update(Ticket obj)
        {
            throw new NotImplementedException();
        }
    }
}
