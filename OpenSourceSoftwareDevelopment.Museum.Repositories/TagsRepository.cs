using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface ITagsRepository : IRepository<Tag>
    {

    }
    public class TagsRepository : ITagsRepository
    {
        private readonly MuseumContext _museumContext;

        public TagsRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public Tag Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Tag>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Tag> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public Tag Insert(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public Tag Update(Tag obj)
        {
            throw new NotImplementedException();
        }
    }
}
