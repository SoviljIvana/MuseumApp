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
                return NotFound(Messages.EXHIBITIONS_GET_ALL_ERROR);
            }
            return Ok(exhibitionDomainModel);

        }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<ExhibitionDomainModel>> GetExhibitionById(int id)
        {
            ExhibitionDomainModel exhibitionDomainModel = await _exhibitionService.GetExhibitionByIdAsync(id);

            if (exhibitionDomainModel == null)
            {
                return NotFound(Messages.EXHIBITION_GET_ID_ERROR + id);
            }

            return Ok(exhibitionDomainModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<ActionResult> DeleteExhibition(int id)
        {
            ExhibitionResultModel exhibitionResult = await _exhibitionService.DeleteExhibition(id);
            if (!exhibitionResult.IsSuccessful)
            {
                return BadRequest(exhibitionResult.ErrorMessage + id);
            }

            return Ok(exhibitionResult.Exhibition);
        }

        [Route("post/")]
        [HttpPost]
        public async Task<ActionResult> PostExhibition([FromBody]CreateExhibitionModel createExhibition)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            ExhibitionDomainModel exhibitionDomainModel = new ExhibitionDomainModel
            {
                ExhibitionId = createExhibition.Id,
                ExhibitionName = createExhibition.ExhibitionName,
                AuditoriumId = createExhibition.AuditoriumId,
                TypeOfExhibition = createExhibition.TypeOfExhibition,
                StartTime = createExhibition.StartTime,
                EndTime = createExhibition.EndTime
             
            };

            var create = await _exhibitionService.CreateExhibition(exhibitionDomainModel);

            return Ok(create);

        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutExhibition(int id, [FromBody]UpdateExhibitionModel updateExhibition)
        {
            throw new NotImplementedException();
        }


    }
}