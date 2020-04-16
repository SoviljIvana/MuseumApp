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
    public class ExhibitService : IExhibitService
    {
        private readonly IExhibitsRepository _exhibitRepository;

        public ExhibitService(IExhibitsRepository exhibitRepository)
        {
            _exhibitRepository = exhibitRepository;
        }

        public async Task<ExhibitDomainModel> CreateExhibit(ExhibitDomainModel exhibitModel)
        {
            ExhibitEntity newExhibit = new ExhibitEntity
            {
                ExhibitId = exhibitModel.ExhibitId,
                ExhibitionId = exhibitModel.ExhibitionId,
                Name = exhibitModel.Name,
                Year = exhibitModel.Year,
                PicturePath = exhibitModel.PicturePath,
                AuditoriumId = exhibitModel.AuditoriumId,

            };

            var data =  _exhibitRepository.Insert(newExhibit);

            ExhibitDomainModel domainModel = new ExhibitDomainModel
            {
                ExhibitId = data.ExhibitId,
                ExhibitionId = data.ExhibitionId,
                Name = data.Name,
                Year = data.Year,
                PicturePath = data.PicturePath,
                AuditoriumId = data.AuditoriumId,
                
             };

            return domainModel;
            
        }

        public async Task<ExhibitResultModel> DeleteExhibit(int id)
        {
            var listOfExhibits = await _exhibitRepository.GetAll();

            if (listOfExhibits == null)
            {
                return new ExhibitResultModel
                {
                    ErrorMessage = Messages.EXHIBITS_EMPTY_LIST,
                    IsSuccessful = false,
                    Exhibit = null
                };
            }
            else
            {
                var existing = _exhibitRepository.Delete(id);

                if (existing == null)
                {
                    return new ExhibitResultModel
                    {
                        ErrorMessage = Messages.EXHIBIT_DOES_NOT_EXIST,
                        IsSuccessful = false,
                        Exhibit = null

                    };
                }
                
                ExhibitResultModel result = new ExhibitResultModel
                {
                    ErrorMessage = null,
                    IsSuccessful = true,
                    Exhibit = new ExhibitDomainModel
                    {
                        ExhibitionId = existing.ExhibitionId,
                        Name = existing.Name,
                        Year = existing.Year,
                        ExhibitId = existing.ExhibitId,
                        PicturePath = existing.PicturePath,
                        AuditoriumId = existing.AuditoriumId
                    }
                };
                return result;
            }
        }

        public async Task<IEnumerable<ExhibitDomainModel>> GetAllExhibits()
        {
            var data = await _exhibitRepository.GetAll();
            if (data == null)
            {
                return null;
            }
            List<ExhibitDomainModel> list = new List<ExhibitDomainModel>();
            ExhibitDomainModel exhibitDomainModel;

            foreach (var item in data)
            {
                exhibitDomainModel = new ExhibitDomainModel
                {
                    ExhibitionId = item.ExhibitionId,
                    Name = item.Name,
                    Year = item.Year,
                    ExhibitId = item.ExhibitId,
                    PicturePath = item.PicturePath,
                    AuditoriumId = item.AuditoriumId
                };
                list.Add(exhibitDomainModel);
            }
            return list;
        }

        public async Task<ExhibitDomainModel> GetExhibitByIdAsync(int id)
        {
            var data = await _exhibitRepository.GetByIdAsync(id);

            if (data == null) return null;

            ExhibitDomainModel result;
            result = new ExhibitDomainModel
            {
                ExhibitId = data.ExhibitId,
                Name = data.Name,
                Year = data.Year,
                PicturePath = data.PicturePath,
                AuditoriumId = data.AuditoriumId,
                ExhibitionId = data.ExhibitionId
            };
            return result;
        }

        public Task<ExhibitResultModel> UpdateExhibit()
        {
            throw new NotImplementedException();
        }
    }
}
