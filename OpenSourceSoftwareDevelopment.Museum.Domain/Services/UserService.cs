using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class UserService : IUserService
    {
        private readonly IUsersRepository _userRepository;

        public UserService(IUsersRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public Task<UserDomainModel> CreateUser()
        {
            throw new NotImplementedException();
        }

        public Task<UserResultModel> CreateUser(UserDomainModel userModel)
        {
            throw new NotImplementedException();
        }

        public Task<UserDomainModel> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserDomainModel>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<UserDomainModel> GetUserByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<UserDomainModel> UpdateUser()
        {
            throw new NotImplementedException();
        }

        Task<UserResultModel> IUserService.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        Task<UserResultModel> IUserService.UpdateUser()
        {
            throw new NotImplementedException();
        }
    }
}
