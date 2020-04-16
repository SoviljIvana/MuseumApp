using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.API.Models;
using OpenSourceSoftwareDevelopment.Museum.Domain.Common;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagDomainModel>>> GetAllTags()
        {
           IEnumerable<TagDomainModel> tagDomainModel = await _tagService.GetAllTags();
            if(tagDomainModel == null)
            {
                return NotFound(Messages.TAGS_GET_ALL_ERROR);
            }
            return Ok(tagDomainModel);
           }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<TagDomainModel>> GetTagById(int id)
        {
            TagDomainModel tagDomainModel = await _tagService.GetTagByIdAsync(id);

            if (tagDomainModel == null)
            {
                return NotFound(Messages.TAG_GET_ID_ERROR + id);
            }

            return Ok(tagDomainModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<ActionResult> DeleteTag(int id)
        {
            TagResultModel tagResault = await _tagService.DeleteTag(id);
            if (!tagResault.IsSuccessful)
            {
                return BadRequest(tagResault.ErrorMessage);
            }

            return Ok(tagResault.Tag);
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<TagDomainModel>> PostTag(CreateTagModel createTag)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutTag(int id, [FromBody]UpdateTagModel updateTag)
        {
            throw new NotImplementedException();
        }
    }
}