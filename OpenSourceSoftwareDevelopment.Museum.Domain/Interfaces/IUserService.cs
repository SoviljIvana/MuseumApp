using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IUserService
    {


        Task<IEnumerable<UserDomainModel>> GetAllUsers();

        Task<UserDomainModel> GetUserByIdAsync(int id);

        Task<UserResultModel> UpdateUser(UserDomainModel userDomainModel);

    }
}
