using Microsoft.EntityFrameworkCore;
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
            UserEntity entity = _museumContext.Users.Find(id);
            var result = _museumContext.Users.Remove(entity);
            return result.Entity;
        }

        public async Task<IEnumerable<UserEntity>> GetAll()
        {
            var data = await _museumContext.Users.ToListAsync();
            return data;
        }

        public async Task<UserEntity> GetByIdAsync(object id)
        {
            var data = await _museumContext.Users.FindAsync(id);
            return data;
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
