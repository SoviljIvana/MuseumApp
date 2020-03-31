using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [Route("api/[controller]")]
    public class ExhibitionsController : ControllerBase
    {
        private readonly IExhibitionService _exhibitionService;

        public ExhibitionsController(IExhibitionService exhibitionService)
        {
            _exhibitionService = exhibitionService;
        }
    
    }
}