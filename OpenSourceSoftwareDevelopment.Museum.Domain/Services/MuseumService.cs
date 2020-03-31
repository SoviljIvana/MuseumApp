using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class MuseumService : IMuseumService
    {
        private readonly IMuseumsRepository _museumRepository;

        public MuseumService(IMuseumsRepository museumRepository)
        {
            _museumRepository = museumRepository;
        }

        public Task<MuseumDomainModel> CreateMuseum()
        {
            throw new NotImplementedException();
        }

        public Task<MuseumDomainModel> DeleteMuseum(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<MuseumDomainModel>> GetAllMuseums()
        {
            throw new NotImplementedException();
        }

        public Task<MuseumDomainModel> GetMuseumByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<MuseumDomainModel> UpdateMuseum()
        {
            throw new NotImplementedException();
        }
    }
}
