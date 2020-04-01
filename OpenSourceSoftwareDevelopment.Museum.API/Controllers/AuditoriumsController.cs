using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuditoriumsController : ControllerBase
    {

        //private readonly IAuditoriumService _auditoriumService;

        //public AuditoriumsController(IAuditoriumService auditoriumService)
        //{
        //    _auditoriumService = auditoriumService;
        //}

        [HttpGet]
        public string Get()
        {
            return "Auditoriums";
        }

    }
}