using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class TagService : ITagService
    {
        private readonly ITagsRepository _tagRepository;

        public TagService(ITagsRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }
    }
}
