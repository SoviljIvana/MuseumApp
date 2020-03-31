using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class TagService : ITagService
    {
        private readonly ITagsRepository _tagRepository;

        public TagService(ITagsRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public Task<TagDomainModel> CreateTag()
        {
            throw new NotImplementedException();
        }

        public Task<TagDomainModel> DeleteTag(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TagDomainModel>> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public Task<TagDomainModel> GetTagByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<TagDomainModel> UpdateTag()
        {
            throw new NotImplementedException();
        }
    }
}
