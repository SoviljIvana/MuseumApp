using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IAuditoriumService
    {

       Task<IEnumerable<AuditoriumDomainModel>> GetAllAuditoriums();
    
       Task<AuditoriumDomainModel> GetAuditoriumByIdAsync(int id);
   
       Task<AuditoriumResultModel> CreateAuditorium(AuditoriumDomainModel createAuditorium);

        Task<AuditoriumResultModel> DeleteAuditorium(int id);
 
       Task<AuditoriumResultModel> UpdateAuditorium();
    }
}
