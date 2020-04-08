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
        public Task<ActionResult<UserDomainModel>> GetUserById(int id)
        {
            throw new NotImplementedException();
        }

        [Route("delete/{id}")]
        [HttpDelete]
        public Task<ActionResult> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        [Route("post/")]
        [HttpPost]
        public Task<ActionResult<UserDomainModel>> PostUser(CreateUserModel createUser)
        {
            throw new NotImplementedException();
        }

        [Route("{id}")]
        [HttpPut]
        public Task<ActionResult> PutUser(int id, [FromBody]UpdateUserModel updateUser)
        {
            throw new NotImplementedException();
        }
    }
}