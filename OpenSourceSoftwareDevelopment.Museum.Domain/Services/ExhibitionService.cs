using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
   public  class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionsRepository _exhibitionRepository;

        public ExhibitionService(IExhibitionsRepository exhibitionRepository)
        {
            _exhibitionRepository = exhibitionRepository;
        }

        public Task<ExhibitionResultModel> CreateExhibition(ExhibitionDomainModel exhibitionModel)
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionResultModel> DeleteExhibition(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<ExhibitionDomainModel>> GetAllExhibitions()
        {
            var data = await _exhibitionRepository.GetAll();

            if(data == null)
            {
                return null;
            }
            List<ExhibitionDomainModel> list = new List<ExhibitionDomainModel>();

            ExhibitionDomainModel exhibitionModel;
            foreach (var item in data)
            {
                exhibitionModel = new ExhibitionDomainModel
                {
                    ExhibitionId = item.ExhibitionId,
                    ExhibitionName = item.ExhibitionName,
                    AuditoriumId = item.AuditoriumId,
                    TypeOfExhibition = item.TypeOfExhibition,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime
                };
                list.Add(exhibitionModel);
            }return list;
        }

        public Task<ExhibitionDomainModel> GetExhibitionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionResultModel> UpdateExhibition()
        {
            throw new NotImplementedException();
        }
    }
}
