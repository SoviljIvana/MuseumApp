using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
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

        public MuseumEntity Delete(object id)
        {
            MuseumEntity entity = _museumContext.Museums.Find(id);
            if (entity == null) return null;
            var result = _museumContext.Museums.Remove(entity);
            _museumContext.SaveChanges();
            return result.Entity;

        }

        public async Task<IEnumerable<MuseumEntity>> GetAll()
        {
            var data = await _museumContext.Museums.ToListAsync();
            return data;
        }

        public async Task<MuseumEntity> GetByIdAsync(object id)
        {
            var data = await _museumContext.Museums.FindAsync(id);
            return data;
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
