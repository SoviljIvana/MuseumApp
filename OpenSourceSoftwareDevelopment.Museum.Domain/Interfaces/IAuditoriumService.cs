using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IAuditoriumService
    {
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       Task<IEnumerable<AuditoriumDomainModel>> GetAllAuditoriums();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       Task<AuditoriumDomainModel> GetAuditoriumByIdAsync(int id);
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       Task<AuditoriumDomainModel> CreateAuditorium();
       /// <summary>
       /// 
       /// </summary>
       /// <param name="id"></param>
       /// <returns></returns>
       Task<AuditoriumDomainModel> DeleteAuditorium(int id);
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       Task<AuditoriumDomainModel> UpdateAuditorium();

    }
}
