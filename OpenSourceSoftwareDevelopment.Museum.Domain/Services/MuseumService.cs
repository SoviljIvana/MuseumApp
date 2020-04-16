using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
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
    public class MuseumService : IMuseumService
    {
        private readonly IMuseumsRepository _museumRepository;
        private readonly IAuditoriumsRepository _auditoriumsRepository;
        private readonly IExhibitionsRepository _exhibitionsRepository;
        private readonly IAuditoriumService _auditoriumService;

        public MuseumService(IMuseumsRepository museumRepository, IAuditoriumsRepository auditoriumsRepository, IAuditoriumService auditoriumService, IExhibitionsRepository exhibitionsRepository)
        {
            _museumRepository = museumRepository;
            _auditoriumsRepository = auditoriumsRepository;
            _auditoriumService = auditoriumService;
            _exhibitionsRepository = exhibitionsRepository;
        }

        public Task<MuseumDomainModel> CreateMuseum(MuseumDomainModel museumModel)
        {
            throw new NotImplementedException();
        }

        public async Task<MuseumResaultModel> DeleteMuseum(int id)
        {
            var auditoriums = await _auditoriumsRepository.GetAll();
            MuseumResaultModel result;
            List<IEntity> entitiesToBeDeleted = new List<IEntity>();

            foreach (var auditorium in auditoriums)
            {
                if (auditorium.MuseumId == id) 
                {
                    List<IEntity> entities = await _auditoriumService.testForDeletionAsync(auditorium.AuditoriumId);
                    if (entities == null)
                    {
                        result = new MuseumResaultModel
                        {
                            Museum = null,
                            IsSuccessful = false,
                            ErrorMessage = Messages.MUSEUM_DELETE_ERROR
                        };
                        return result;
                    }
                    else
                    {
                        entitiesToBeDeleted.AddRange(entities);
                        entitiesToBeDeleted.Add(auditorium);
                    }
                }
            }

            foreach (var entity in entitiesToBeDeleted)
                switch (entity.getType())
                {
                    case 1:
                        _auditoriumsRepository.Delete(entity.getId());
                        break;
                    case 3:
                        _exhibitionsRepository.Delete(entity.getId());
                        break;
                }

            var deletedMuseum = _museumRepository.Delete(id);
            if (deletedMuseum == null)
                return new MuseumResaultModel
                {
                    Museum = null,
                    IsSuccessful = false,
                    ErrorMessage = Messages.MUSEUM_NOT_FOUND_ERROR
                };

            result = new MuseumResaultModel
            {
                Museum = new MuseumDomainModel
                {
                    MuseumId = deletedMuseum.MuseumId,
                    StreetAndNumber = deletedMuseum.StreetAndNumber,
                    City = deletedMuseum.City,
                    Email = deletedMuseum.Email,
                    Name = deletedMuseum.Name,
                    PhoneNumber = deletedMuseum.PhoneNumber
                },
                IsSuccessful = true,
                ErrorMessage = ""
            };
            return result;
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

        public async Task<MuseumDomainModel> GetMuseumByIdAsync(int id)
        {
            var data = await _museumRepository.GetByIdAsync(id);
            
            if (data == null) return null;

            MuseumDomainModel result;
            result = new MuseumDomainModel
            {
                MuseumId = data.MuseumId,
                Name = data.Name,
                StreetAndNumber = data.StreetAndNumber,
                City = data.City,
                Email = data.Email,
                PhoneNumber = data.PhoneNumber
            };
            return result;
        }

        public Task<MuseumDomainModel> UpdateMuseum()
        {
            throw new NotImplementedException();
        }
    }
}
