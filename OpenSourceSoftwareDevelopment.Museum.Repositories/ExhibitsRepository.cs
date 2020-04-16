using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
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
        public  ExhibitEntity Delete(object id)
        {

            ExhibitEntity entity =  _museumContext.Exhibits.Find(id);
            if (entity == null) return null;
            var result = _museumContext.Exhibits.Remove(entity);
            _museumContext.SaveChanges();
            return result.Entity;
        }

        public async Task<IEnumerable<ExhibitEntity>> GetAll()
        {
            var data = await _museumContext.Exhibits.ToListAsync();
            if(data.Count == 0)
            {
                return null;
            }
            return data;
        }

        public async Task<ExhibitEntity> GetByIdAsync(object id)
        {
            var data = await _museumContext.Exhibits.FindAsync(id);
            return data;
        }

        public ExhibitEntity Insert(ExhibitEntity obj)
        {
            var data = _museumContext.Exhibits.Add(obj).Entity;
            _museumContext.SaveChanges();
            return data;
        }
      


        public void Save()
        {
            _museumContext.SaveChanges();
        }

        public ExhibitEntity Update(ExhibitEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
