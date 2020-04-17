﻿using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
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
        private readonly IMuseumsRepository _museumsRepository;

        public AuditoriumService(IAuditoriumsRepository auditoriumRepository, IExhibitionsRepository exhibitionsRepository, IMuseumsRepository museumsRepository)
        {
            _auditoriumRepository = auditoriumRepository;
            _exhibitionsRepository = exhibitionsRepository;
            _museumsRepository = museumsRepository;
        }


        public async Task<AuditoriumResultModel> CreateAuditorium(AuditoriumDomainModel createAuditorium)
        {

            AuditoriumEntity newAuditorium = new AuditoriumEntity
            {
                AuditoriumId = createAuditorium.AuditoriumId,
                NameOfAuditorium = createAuditorium.NameOfAuditorium,
                MuseumId = createAuditorium.MuseumId,
                NumberOfSeats = createAuditorium.NumberOfSeats
            };
            bool museum = false;
            var listOfMuseums = await _museumsRepository.GetAll();
            foreach (var item in listOfMuseums)
            {
                if (item.MuseumId == createAuditorium.MuseumId)
                {
                    museum = true;
                };
            }
            if (museum == false)
            {
                return new AuditoriumResultModel
                {
                    IsSuccessful = false,
                    ErrorMessage = Messages.MUSEUM_DOES_NOT_EXIST,
                    Auditorium = null
                };

            }
            
            var auditorium = _auditoriumRepository.Insert(newAuditorium);

            if (auditorium == null)
            {
                return new AuditoriumResultModel
                {
                    IsSuccessful = false,
                    ErrorMessage = Messages.AUDITORIUM_WITH_THIS_ID_ALREADY_EXISTS,
                    Auditorium = null
                };
            }

            AuditoriumResultModel result = new AuditoriumResultModel
            {
                IsSuccessful = true,
                ErrorMessage = null,
                Auditorium = new AuditoriumDomainModel
                {
                    AuditoriumId = auditorium.AuditoriumId,
                    NameOfAuditorium = auditorium.NameOfAuditorium,
                    MuseumId = auditorium.MuseumId,
                    NumberOfSeats = auditorium.NumberOfSeats
                }
            };
            return result;
        }


        public async Task<IEnumerable<AuditoriumDomainModel>> GetAllAuditoriums()
        {
            var data = await _auditoriumRepository.GetAll();

            if (data == null)
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
            List<IEntity> entitiesToBeDeleted = new List<IEntity>();

            //&& exhibition.StartTime > DateTime.Now ) || (exhibition.AuditoriumId == id && exhibition.EndTime > DateTime.Now)
            var entities = await testForDeletionAsync(id);
            if(entities == null)
                return new AuditoriumResultModel
                {
                    Auditorium = null,
                    IsSuccessful = false,
                    ErrorMessage = Messages.AUDITORIUM_DELETE_ERROR
                };
            else
            entitiesToBeDeleted.AddRange(entities);


            foreach (var entity in entitiesToBeDeleted)
            {
                switch (entity.getType())
                {
                    case 3:
                        _exhibitionsRepository.Delete(entity.getId());
                        break;
                }
            }
            var deletedAuditorium = _auditoriumRepository.Delete(id);
            if (deletedAuditorium == null)
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

        public async Task<List<IEntity>> testForDeletionAsync(int id) 
        {
            List<IEntity> result = new List<IEntity>();
            var exhibitions = await _exhibitionsRepository.GetAll();

            foreach (var exhibition in exhibitions) 
            {
                if (exhibition.AuditoriumId == id)
                {
                    if (exhibition.EndTime > DateTime.Now) return null;
                    else result.Add(exhibition);
                }
            }
            return result;
        }
    }
}
