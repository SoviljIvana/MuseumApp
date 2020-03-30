using System;
using System.Collections.Generic;
using System.Text;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IMuseumsRepository : IRepository<Data.Entities.Museum>
    {

    }
    public class MuseumsRepository : IMuseumsRepository
    {
        private readonly MuseumContext _museumContext;

        public MuseumsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Data.Entities.Museum Delete(object id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<IEnumerable<Data.Entities.Museum>> GetAll()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<Data.Entities.Museum> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Data.Entities.Museum Insert(Data.Entities.Museum obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Data.Entities.Museum Update(Data.Entities.Museum obj)
        {
            throw new NotImplementedException();
        }
    }
}
