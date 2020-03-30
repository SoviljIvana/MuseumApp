using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{

    public interface IAuditoriumsRepository : IRepository<Auditorium>
    {

    }
    public class AuditoriumsRepository : IAuditoriumsRepository
    {
        private readonly MuseumContext _museumContext;

        public AuditoriumsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        public Auditorium Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Auditorium>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Auditorium> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Auditorium Insert(Auditorium obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Auditorium Update(Auditorium obj)
        {
            throw new NotImplementedException();
        }
    }
}
