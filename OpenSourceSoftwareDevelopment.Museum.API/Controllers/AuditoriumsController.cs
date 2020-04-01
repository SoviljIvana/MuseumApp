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

        [Route("{name}")]
        [HttpDelete]
        public List<string> GetListOfStrings(String name)
        {
            List<string> listOfStrings1 = new List<string>();
            List<string> listOfStrings2 = new List<string>();

            listOfStrings1.Add("Ivana");
            listOfStrings1.Add("Marija");
            listOfStrings1.Add("Tamara");

            listOfStrings2.Add("Can't find name!");
            for (int i = 0; i < listOfStrings1.Count; i++) {
                if (name == listOfStrings1[i])
                {
                    return listOfStrings1;
              }
       
            }
            return listOfStrings2;

        }
    }
}