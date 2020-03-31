using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IUsersRepository : IRepository<UserEntity>
    {

    }
    public class UsersRepository : IUsersRepository
    {
        private readonly MuseumContext _museumContext;

        public UsersRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public UserEntity Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<UserEntity>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<UserEntity> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public UserEntity Insert(UserEntity obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public UserEntity Update(UserEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
