using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{

    public interface IExhibitionsRepository : IRepository<ExhibitionEntity>
    {

    }
    public class ExhibitionsRepository : IExhibitionsRepository
    {
        private readonly MuseumContext _museumContext;

        public ExhibitionsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public ExhibitionEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExhibitionEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public ExhibitionEntity Insert(ExhibitionEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public ExhibitionEntity Update(ExhibitionEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
