using OpenSourceSoftwareDevelopment.Museum.Data.Context;
using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Repositories
{
    public interface IUsersRepository : IRepository<User>
    {

    }
    public class UsersRepository : IUsersRepository
    {
        private readonly MuseumContext _museumContext;

        public UsersRepository(MuseumContext museumContext)
        {
            _museumContext = museumContext;
        }
        public User Delete(object id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(object id)
        {
            throw new NotImplementedException();
        }

        public User Insert(User obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public User Update(User obj)
        {
            throw new NotImplementedException();
        }
    }
}
