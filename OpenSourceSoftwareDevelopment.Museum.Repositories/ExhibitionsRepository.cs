using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{

    public interface IExhibitionsRepository : IRepository<Exhibition>
    {

    }
    public class ExhibitionsRepository : IExhibitionsRepository
    {
        private readonly MuseumContext _museumContext;

        public ExhibitionsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Exhibition Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Exhibition>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Exhibition> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Exhibition Insert(Exhibition obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Exhibition Update(Exhibition obj)
        {
            throw new NotImplementedException();
        }
    }
}
