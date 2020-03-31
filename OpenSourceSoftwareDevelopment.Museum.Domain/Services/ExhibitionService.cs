using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
   public  class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionsRepository _exhibitionRepository;

        public ExhibitionService(IExhibitionsRepository exhibitionRepository)
        {
            _exhibitionRepository = exhibitionRepository;
        }
    }
}
