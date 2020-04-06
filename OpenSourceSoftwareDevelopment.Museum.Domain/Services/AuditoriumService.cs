using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class AuditoriumService : IAuditoriumService
    {
        private readonly IAuditoriumsRepository _auditoriumRepository;

        public AuditoriumService(IAuditoriumsRepository auditoriumRepository)
        {
            _auditoriumRepository = auditoriumRepository;
        }


        public Task<AuditoriumResultModel> CreateAuditorium(AuditoriumDomainModel createAuditorium)
        {
            throw new NotImplementedException();
        }


        public async  Task<IEnumerable<AuditoriumDomainModel>> GetAllAuditoriums()
        {
            var data = await _auditoriumRepository.GetAll();

            if(data == null)
            {
                return null;
            }
            List<AuditoriumDomainModel> list = new List<AuditoriumDomainModel>();

            AuditoriumDomainModel model;
            foreach (var item in data)
            {
                model = new AuditoriumDomainModel
                {
                    AuditoriumId = item.AuditoriumId,
                    NameOfAuditorium = item.NameOfAuditorium,
                    NumberOfSeats = item.NumberOfSeats,
                    MuseumId = item.MuseumId
                };
                list.Add(model);
            }
            return list;           
        }

        public Task<AuditoriumDomainModel> GetAuditoriumByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        Task<AuditoriumResultModel> IAuditoriumService.DeleteAuditorium(int id)
        {
            throw new NotImplementedException();
        }

        Task<AuditoriumResultModel> IAuditoriumService.UpdateAuditorium()
        {
            throw new NotImplementedException();
        }
    }
}
