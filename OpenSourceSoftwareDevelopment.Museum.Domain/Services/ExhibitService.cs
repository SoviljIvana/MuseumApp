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

        public Task<ExhibitResultModel> DeleteExhibit(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ExhibitDomainModel>> GetAllExhibits()
        {
            var data = await _exhibitRepository.GetAll();
            if(data == null)
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
