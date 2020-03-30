using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class MuseumService : IMuseumService
    {
        private readonly IMuseumsRepository _museumRepository;

        public MuseumService(IMuseumsRepository museumRepository)
        {
            _museumRepository = museumRepository;
        }
    }
}
