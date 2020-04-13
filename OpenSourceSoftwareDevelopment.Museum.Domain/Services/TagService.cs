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

        public Task<TagDomainModel> CreateTag(TagDomainModel tagModel)
        {
            throw new NotImplementedException();
        }

        public Task<TagDomainModel> DeleteTag(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<TagDomainModel>> GetAllTags()
        {
            var data = await _tagRepository.GetAll();

            if(data == null)
            {
                return null;
            }
            TagDomainModel tagDomainModel;
            List<TagDomainModel> list = new List<TagDomainModel>();

            foreach(var item in data)
            {
                tagDomainModel = new TagDomainModel
                {
                    Id = item.TagId,
                    Name = item.Name,
                    Type = item.Type
                };

                list.Add(tagDomainModel);
            }
            return list;
            
        }

        public async Task<TagDomainModel> GetTagByIdAsync(int id)
        {
            var data = await _tagRepository.GetByIdAsync(id);

            if (data == null) return null;

            TagDomainModel result;
            result = new TagDomainModel
            {
                Id = data.TagId,
                Name = data.Name,
                Type = data.Type
            };
            return result;
        }

        public Task<TagDomainModel> UpdateTag()
        {
            throw new NotImplementedException();
        }
    }
}
