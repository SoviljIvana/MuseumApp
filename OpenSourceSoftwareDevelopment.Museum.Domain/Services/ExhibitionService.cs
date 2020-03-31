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

        public Task<ExhibitionDomainModel> CreateExhibition()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionDomainModel> DeleteExhibition(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExhibitionDomainModel>> GetAllExhibitions()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionDomainModel> GetExhibitionByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitionDomainModel> UpdateExhibition()
        {
            throw new NotImplementedException();
        }
    }
}
