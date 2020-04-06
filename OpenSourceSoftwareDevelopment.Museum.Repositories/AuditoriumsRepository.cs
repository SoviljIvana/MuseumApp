using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{

    public interface IAuditoriumsRepository : IRepository<AuditoriumEntity>
    {

    }
    public class AuditoriumsRepository : IAuditoriumsRepository
    {
        private readonly MuseumContext _museumContext;

        public AuditoriumsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }

        public AuditoriumEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<AuditoriumEntity>> GetAll()
        {
            var data = await _museumContext.Auditoriums.ToListAsync();
            return data;
        }

        public Task<AuditoriumEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public AuditoriumEntity Insert(AuditoriumEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public AuditoriumEntity Update(AuditoriumEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
