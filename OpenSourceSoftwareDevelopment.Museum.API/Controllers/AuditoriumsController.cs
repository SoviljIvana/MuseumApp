using System;
using System.Collections.Generic;
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
    public class AuditoriumsController : ControllerBase
    {

        private readonly IAuditoriumService _auditoriumService;

        public AuditoriumsController(IAuditoriumService auditoriumService)
        {
            _auditoriumService = auditoriumService;
        }

        [Route("get")]
        [HttpGet]
        public  async Task<ActionResult<IEnumerable<AuditoriumDomainModel>>> GetAllAuditoriums()
        {
            IEnumerable<AuditoriumDomainModel> auditoriumDomainModel;
            auditoriumDomainModel = await _auditoriumService.GetAllAuditoriums();

            if(auditoriumDomainModel == null)
            {
                return NotFound(Messages.AUDITORIUM_GET_ALL_ERROR);
            }
            return Ok(auditoriumDomainModel);
        }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<AuditoriumDomainModel>> GetAuditoriumById(int id)
        {
            AuditoriumDomainModel auditoriumDomainModel = await _auditoriumService.GetAuditoriumByIdAsync(id);

            if (auditoriumDomainModel == null)
            {
                return NotFound(Messages.AUDITORIUM_GET_ID_ERROR + id);
            }

            return Ok(auditoriumDomainModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public async Task<ActionResult> DeleteAuditoriumAsync(int id)
        {
            AuditoriumResultModel auditoriumResult = await _auditoriumService.DeleteAuditoriumAsync(id);
            if (!auditoriumResult.IsSuccessful)
            {
                return BadRequest(auditoriumResult.ErrorMessage + id);
            }

            return Ok(auditoriumResult.Auditorium);
        }
      
        [Route("post/")]
        [HttpPost]
        public async Task<ActionResult<AuditoriumDomainModel>> PostAuditorium(CreateAuditoriumModel createAuditorium)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            AuditoriumDomainModel auditoriumDomainModel = new AuditoriumDomainModel
            {
                AuditoriumId = createAuditorium.AuditoriumId,
                NameOfAuditorium = createAuditorium.NameOfAuditorium,
                MuseumId = createAuditorium.MuseumId,
                NumberOfSeats = createAuditorium.NumberOfSeats

            };

            var create = await _auditoriumService.CreateAuditorium(auditoriumDomainModel);

            return Ok(create);
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutAuditorium(int id, [FromBody]UpdateAuditoriumModel updateAuditorium )
        {
            throw new NotImplementedException();
        }


        //[HttpGet]
        //public string Get()
        //{
        //    return "Auditoriums";
        //}

        //[Route("{name}")]
        //[HttpDelete]
        //public List<string> GetListOfStrings(String name)
        //{
        //    List<string> listOfStrings1 = new List<string>();
        //    List<string> listOfStrings2 = new List<string>();

        //    listOfStrings1.Add("Ivana");
        //    listOfStrings1.Add("Marija");
        //    listOfStrings1.Add("Tamara");

        //    listOfStrings2.Add("Can't find name!");
        //    for (int i = 0; i < listOfStrings1.Count; i++) {
        //        if (name == listOfStrings1[i])
        //        {
        //            return listOfStrings1;
        //      }

        //    }
        //    return listOfStrings2;
        //}

    }
}