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

        public Task<ExhibitResultModel> CreateExhibit(ExhibitDomainModel exhibitModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ExhibitResultModel> DeleteExhibit(int id)
        {
            var listOfExhibits = await _exhibitRepository.GetAll();
            var existing = await _exhibitRepository.GetByIdAsync(id);
            int counterId = 0;

            if (listOfExhibits == null)
            {
                return new ExhibitResultModel
                {
                    ErrorMessage = Messages.EXHIBITS_EMPTY_LIST,
                    IsSuccessful = false
                };
            }
            else
            {
                foreach (var item in listOfExhibits)
                {
                    if (item.ExhibitId == id)
                    {
                        _exhibitRepository.Delete(id);
                        counterId += 1;
                    }
                }

                if (counterId == 0)
                {
                    return new ExhibitResultModel
                    {
                        ErrorMessage = Messages.EXHIBIT_DOES_NOT_LIST,
                        IsSuccessful = false
                    };
                }
                _exhibitRepository.Save();

                ExhibitResultModel result = new ExhibitResultModel
                {
                    ErrorMessage = null,
                    IsSuccessful = true,
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
