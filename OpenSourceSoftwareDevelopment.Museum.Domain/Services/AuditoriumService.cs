using OpenSourceSoftwareDevelopment.Museum.Domain.Common;
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
        private readonly IExhibitionsRepository _exhibitionsRepository;

        public AuditoriumService(IAuditoriumsRepository auditoriumRepository, IExhibitionsRepository exhibitionsRepository)
        {
            _auditoriumRepository = auditoriumRepository;
            _exhibitionsRepository = exhibitionsRepository;
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

        public async Task<AuditoriumDomainModel> GetAuditoriumByIdAsync(int id)
        {
            var data = await _auditoriumRepository.GetByIdAsync(id);

            if (data == null) return null;

            AuditoriumDomainModel result;
            result = new AuditoriumDomainModel
            {
                AuditoriumId = data.AuditoriumId,
                NameOfAuditorium = data.NameOfAuditorium,
                NumberOfSeats = data.NumberOfSeats,
                MuseumId = data.MuseumId
            };
            return result;
        }

        public async Task<AuditoriumResultModel> DeleteAuditoriumAsync(int id)
        {
            var exhibitions = await _exhibitionsRepository.GetAll();
            AuditoriumResultModel result;

            foreach (var exhibition in exhibitions) 
            {
                if ((exhibition.AuditoriumId == id && exhibition.StartTime > DateTime.Now ) || (exhibition.AuditoriumId == id && exhibition.EndTime > DateTime.Now))
                {
                    result = new AuditoriumResultModel
                    {
                        Auditorium = null,
                        IsSuccessful = false,
                        ErrorMessage = Messages.EXHIBITION_IN_THE_FUTURE
                    };
                    return result;
                }
            }

            var deletedAuditorium = _auditoriumRepository.Delete(id);
            if(deletedAuditorium == null)
                return new AuditoriumResultModel
                    {
                        Auditorium = null,
                        IsSuccessful = false,
                        ErrorMessage = Messages.AUDITORIUM_NOT_FOUND_ERROR
                    };

            result = new AuditoriumResultModel
            {
                Auditorium = new AuditoriumDomainModel 
                { 
                    AuditoriumId = deletedAuditorium.AuditoriumId,
                    NameOfAuditorium = deletedAuditorium.NameOfAuditorium,
                    MuseumId = deletedAuditorium.MuseumId,
                    NumberOfSeats = deletedAuditorium.NumberOfSeats
                },
                IsSuccessful = true,
                ErrorMessage = ""
            };
            return result;
        }

        Task<AuditoriumResultModel> IAuditoriumService.UpdateAuditorium()
        {
            throw new NotImplementedException();
        }
    }
}
