using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IExhibitsRepository : IRepository<ExhibitEntity>
    {

    }
    public class ExhibitsRepository : IExhibitsRepository
    {
        private readonly MuseumContext _museumContext;

        public ExhibitsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public ExhibitEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExhibitEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public ExhibitEntity Insert(ExhibitEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public ExhibitEntity Update(ExhibitEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
