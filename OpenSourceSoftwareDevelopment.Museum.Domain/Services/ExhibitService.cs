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

        public Task<ExhibitDomainModel> CreateExhibit()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitDomainModel> DeleteExhibit(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ExhibitDomainModel>> GetAllExhibits()
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitDomainModel> GetExhibitByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ExhibitDomainModel> UpdateExhibit()
        {
            throw new NotImplementedException();
        }
    }
}
