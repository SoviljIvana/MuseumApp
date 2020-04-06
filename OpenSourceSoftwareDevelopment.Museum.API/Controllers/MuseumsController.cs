﻿using System;
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
    public class MuseumsController : ControllerBase
    {

        private readonly IMuseumService _museumService;

        public MuseumsController(IMuseumService museumService)
        {
            _museumService = museumService;
        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MuseumDomainModel>>> GetAllMuseums()
        {
            IEnumerable<MuseumDomainModel> museumDomainModel;
            museumDomainModel = await _museumService.GetAllMuseums(); //puca

            if(museumDomainModel == null)
            {
                return NotFound(Messages.MUSEUM_GET_ALL_ERROR);
            }

            return Ok(museumDomainModel);
        }


        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<MuseumDomainModel>> GetMuseumById(int id)
        {
            MuseumDomainModel museumDomainModel = await _museumService.GetMuseumByIdAsync(id);

            if (museumDomainModel == null)
            {
                return NotFound(Messages.MUSEUM_GET_ALL_ERROR);
            }

            return Ok(museumDomainModel);
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public Task<ActionResult> DeleteMuseum(int id)
        {
            throw new NotImplementedException();
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<MuseumDomainModel>> PostMuseum(CreateMuseumModel createMuseum)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutMuseum(int id, [FromBody]UpdateMuseumModel updateMuseum)
        {
            throw new NotImplementedException();
        }
    }
}