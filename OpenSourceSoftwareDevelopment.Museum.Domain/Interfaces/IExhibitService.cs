using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IExhibitService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ExhibitDomainModel>> GetAllExhibits();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ExhibitDomainModel> GetExhibitByIdAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ExhibitDomainModel> CreateExhibit();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ExhibitDomainModel> DeleteExhibit(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ExhibitDomainModel> UpdateExhibit();
    }
}
