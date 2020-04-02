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

        public Task<MuseumDomainModel> CreateMuseum(MuseumDomainModel museumModel)
        {
            throw new NotImplementedException();
        }

        public Task<MuseumDomainModel> DeleteMuseum(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MuseumDomainModel>> GetAllMuseums()
        {
            var data = await _museumRepository.GetAll();

            if (data == null)
            {
                return null;
            }

            List<MuseumDomainModel> result = new List<MuseumDomainModel>();
            MuseumDomainModel model;
            foreach (var item in data)
            {
                model = new MuseumDomainModel
                {
                    MuseumId = item.MuseumId,
                    Name = item.Name,
                    StreetAndNumber = item.StreetAndNumber,
                    City = item.City,
                    Email = item.Email,
                    PhoneNumber = item.PhoneNumber
                };
                result.Add(model);
            }
            return result;
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
