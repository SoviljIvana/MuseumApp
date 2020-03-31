using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<UserDomainModel>> GetAllUsers();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserDomainModel> GetUserByIdAsync(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<UserDomainModel> CreateUser();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<UserDomainModel> DeleteUser(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<UserDomainModel> UpdateUser();
    }
}
