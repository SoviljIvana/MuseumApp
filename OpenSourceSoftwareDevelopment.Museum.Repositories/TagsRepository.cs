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
        public TagEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<TagEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
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
