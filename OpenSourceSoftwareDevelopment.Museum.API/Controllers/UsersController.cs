using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenSourceSoftwareDevelopment.Museum.API.Models;
using OpenSourceSoftwareDevelopment.Museum.Domain.Common;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;

namespace OpenSourceSoftwareDevelopment.Museum.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [Route("get")]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDomainModel>>> GetAllUsers()
        {
            IEnumerable<UserDomainModel> userDomainModel = await _userService.GetAllUsers();
            if(userDomainModel == null)
            {
                return NotFound(Messages.USERS_GET_ALL_ERROR);
            }
            return Ok(userDomainModel);
        }

        [Route("get/{id}")]
        [HttpGet]
        public async Task<ActionResult<UserDomainModel>> GetUserById(int id)
        {
            UserDomainModel userDomainModels = await _userService.GetUserByIdAsync(id);
            if(userDomainModels == null)
            {
                return NotFound(Messages.USERS_GET_ID_ERROR);
            }
            return Ok(userDomainModels);
            
           
        }


        [Route("put/{id}")]
        [HttpPut]
        public async Task<ActionResult> PutUser(int id, [FromBody]UpdateUserModel updateUser)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var userUpdate = await _userService.GetUserByIdAsync(id);


            if(userUpdate == null)
            {
               return NotFound(Messages.USER_DOES_NOT_EXIST);              
            }

            userUpdate.FirstName = updateUser.FirstName;
            userUpdate.LastName = updateUser.LastName;
            userUpdate.Email = updateUser.Email;
            userUpdate.YearOfBirth = updateUser.YearOfBirth;

            var update = await  _userService.UpdateUser(userUpdate);

            if (!update.IsSuccessful) return BadRequest(update);

            return Ok(update); 

        }
    }
}