using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces
{
    public interface IExhibitionService
    {

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<ExhibitionDomainModel>>GetAllExhibitions();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ExhibitionDomainModel> GetExhibitionByIdAsync(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ExhibitionDomainModel> CreateExhibition();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<ExhibitionDomainModel> DeleteExhibition(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<ExhibitionDomainModel> UpdateExhibition();
    }
}
