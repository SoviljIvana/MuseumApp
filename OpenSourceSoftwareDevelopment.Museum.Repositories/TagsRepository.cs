using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface ITagsRepository : IRepository<TagEntity>
    {

    }
    public class TagsRepository : ITagsRepository
    {
        private readonly MuseumContext _museumContext;

        public TagsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public  TagEntity Delete(object id)
        {
            TagEntity entity = _museumContext.Tags.Find(id);
            if (entity == null) return null;
            var result = _museumContext.Tags.Remove(entity);
            _museumContext.SaveChanges();
            return result.Entity;
        }

        public async Task<IEnumerable<TagEntity>> GetAll()
        {
            var data = await _museumContext.Tags.ToListAsync();
            if (data.Count == 0)
            {
                return null;
            }
            return data;
        }

        public async Task<TagEntity> GetByIdAsync(object id)
        {
            var data = await _museumContext.Tags.FindAsync(id);
            return data;
        }

        public TagEntity Insert(TagEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public TagEntity Update(TagEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
