using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IExhibitsRepository : IRepository<Exhibit>
    {

    }
    public class ExhibitsRepository : IExhibitsRepository
    {
        private readonly MuseumContext _museumContext;

        public ExhibitsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Exhibit Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Exhibit>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Exhibit> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Exhibit Insert(Exhibit obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Exhibit Update(Exhibit obj)
        {
            throw new NotImplementedException();
        }
    }
}
