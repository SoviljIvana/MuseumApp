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
    public class ExhibitsController : ControllerBase
    {
        private readonly IExhibitService _exhibitService;

        public ExhibitsController(IExhibitService exhibitService)
        {
            _exhibitService = exhibitService;
        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ExhibitDomainModel>>> GetAllExhibits()
        {
            IEnumerable<ExhibitDomainModel> exhibitDomainModel = await _exhibitService.GetAllExhibits();

            if (exhibitDomainModel == null)
            {
                return NotFound(Messages.EXHIBITS_GET_ALL_ERROR);

            }
            return Ok(exhibitDomainModel);

        }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExhibitDomainModel>> GetExhibitById(int id)
        {
            ExhibitDomainModel exhibitDomainModel = await _exhibitService.GetExhibitByIdAsync(id);

            if (exhibitDomainModel == null)
            {
                return NotFound(Messages.EXHIBIT_GET_ID_ERROR + id);
            }

            return Ok(exhibitDomainModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public Task<ActionResult> DeleteExhibit(int id)
        {
            throw new NotImplementedException();
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<ExhibitDomainModel>> PostExhibition(CreateExhibitModel createExhibit)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutExhibit(int id, [FromBody]UpdateExhibitModel updateExhibit)
        {
            throw new NotImplementedException();
        }
    }
}