using System;
using System.Collections.Generic;
using System.Text;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IMuseumsRepository : IRepository<Data.Entities.MuseumEntity>
    {

    }
    public class MuseumsRepository : IMuseumsRepository
    {
        private readonly MuseumContext _museumContext;

        public MuseumsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Data.Entities.MuseumEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<IEnumerable<Data.Entities.MuseumEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public System.Threading.Tasks.Task<Data.Entities.MuseumEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Data.Entities.MuseumEntity Insert(Data.Entities.MuseumEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Data.Entities.MuseumEntity Update(Data.Entities.MuseumEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
