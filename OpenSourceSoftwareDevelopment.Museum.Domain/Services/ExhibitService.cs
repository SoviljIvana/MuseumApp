using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class ExhibitService : IExhibitService
    {
        private readonly IExhibitsRepository _exhibitRepository;
        
        public ExhibitService(IExhibitsRepository exhibitRepository)
        {
            _exhibitRepository = exhibitRepository;
        }
    }
}
