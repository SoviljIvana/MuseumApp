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

        public async Task<IEnumerable<UserDomainModel>> GetAllUsers()
        {
            var data = await _userRepository.GetAll();
            if(data == null)
            {
                return null;
            }

            List<UserDomainModel> list = new List<UserDomainModel>();
            UserDomainModel userDomainModel;
       
        
        foreach(var item in data)
            {
                userDomainModel = new UserDomainModel
                {
                    UserId = item.UserId,
                    Username = item.Username,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Password = item.Password,
                    YearOfBirth = item.YearOfBirth,
                    Email = item.Email
                };

                list.Add(userDomainModel);
            }


            return list;
        }

        public async Task<UserDomainModel> GetUserByIdAsync(int id)
        {
            var data = await _userRepository.GetByIdAsync(id);
            if(data == null)
            {
                return null;
            }

            UserDomainModel result = new UserDomainModel
            {
                UserId = data.UserId,
                Username = data.Username,
                Password = data.Password,
                FirstName = data.FirstName,
                LastName = data.LastName,
                YearOfBirth = data.YearOfBirth,
                Email = data.Email,
            };
            return result;
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
