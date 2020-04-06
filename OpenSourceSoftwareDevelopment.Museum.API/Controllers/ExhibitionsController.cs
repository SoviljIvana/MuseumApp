using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.API.Models;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ExhibitionsController : ControllerBase
    {
        private readonly IExhibitionService _exhibitionService;

        public ExhibitionsController(IExhibitionService exhibitionService)
        {
            _exhibitionService = exhibitionService;
        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExhibitionDomainModel>>> GetAllExhibitions()
        {
            IEnumerable<ExhibitionDomainModel> exhibitionDomainModel;
            exhibitionDomainModel = await _exhibitionService.GetAllExhibitions();
            if(exhibitionDomainModel == null)
            {
                return NotFound();
            }
            return Ok(exhibitionDomainModel);

        }

        [Route("get/{id}")]
        [HttpGet]
        public Task<ActionResult<ExhibitionDomainModel>> GetExhibitionById(int id)
        {
            throw new NotImplementedException();
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public Task<ActionResult> DeleteExhibition(int id)
        {
            throw new NotImplementedException();
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<ExhibitionDomainModel>> PostExhibition(CreateExhibitionModel createExhibition)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutExhibition(int id, [FromBody]UpdateExhibitionModel updateExhibition)
        {
            throw new NotImplementedException();
        }


    }
}