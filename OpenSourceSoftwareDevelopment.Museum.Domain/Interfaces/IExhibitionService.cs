﻿using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IExhibitionService
    {


        Task<IEnumerable<ExhibitionDomainModel>>GetAllExhibitions();

        Task<ExhibitionDomainModel> GetExhibitionByIdAsync(int id);

        Task<ExhibitionDomainModel> CreateExhibition(ExhibitionDomainModel exhibitionModel);

        Task<ExhibitionResultModel> DeleteExhibition(int id);
        Task<ExhibitionResultModel> UpdateExhibition();
      
      
    }
}
