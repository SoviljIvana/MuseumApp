using OpenSourceSoftwareDevelopment.Museum.Domain.Common;
using OpenSourceSoftwareDevelopment.Museum.Domain.Interfaces;
using OpenSourceSoftwareDevelopment.Museum.Domain.Models;
using OpenSourceSoftwareDevelopment.Museum.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Services
{
    public class ExhibitionService : IExhibitionService
    {
        private readonly IExhibitionsRepository _exhibitionRepository;
        private readonly ITicketsRepository _ticketsRepository;

        public ExhibitionService(IExhibitionsRepository exhibitionRepository, ITicketsRepository ticketsRepository)
        {
            _exhibitionRepository = exhibitionRepository;
            _ticketsRepository = ticketsRepository;
        }

        public Task<ExhibitionResultModel> CreateExhibition(ExhibitionDomainModel exhibitionModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ExhibitionResultModel> DeleteExhibition(int id)
        {
            var listOfExhibitions = await _exhibitionRepository.GetAll();

            if (listOfExhibitions == null)
            {
                return new ExhibitionResultModel
                {
                    ErrorMessage = Messages.EXHIBITIONS_LIST_IS_EMPTY,
                    IsSuccessful = false,
                    Exhibition = null
                };
            }
            else
            {
                var listOfTickets = await _ticketsRepository.GetAll();

                foreach(var ticket in listOfTickets) { 
                    if(ticket.ExhibitionId == id)
                    {
                        return new ExhibitionResultModel
                        {
                            ErrorMessage = Messages.A_TICKET_TO_THIS_EXHIBITION_WAS_PURCHASED,
                            IsSuccessful = false,
                            Exhibition = null

                        };
                    }
                }

                var existing =  await _exhibitionRepository.GetByIdAsync(id);

                if (existing == null)
                {
                    return new ExhibitionResultModel
                    {
                        ErrorMessage = Messages.EXHIBITION_DOES_NOT_EXIST,
                        IsSuccessful = false,
                        Exhibition = null

                    };
                }

                //exhibition in the future
                if (existing.StartTime > DateTime.Now)
                {
                    return new ExhibitionResultModel
                    {
                        ErrorMessage = Messages.EXHIBITION_IN_THE_FUTURE,
                        IsSuccessful = false,
                        Exhibition = null

                    };
                }

                //The exhibition began but wasn't finished
                if ((existing.EndTime == DateTime.Now) || (existing.EndTime > DateTime.Now))
                {
                    return new ExhibitionResultModel
                    {
                        ErrorMessage = Messages.EXHIBITION_IS_NOT_OVER,
                        IsSuccessful = false,
                        Exhibition = null

                    };
                }
              var deletedExhibition =  _exhibitionRepository.Delete(id);
                ExhibitionResultModel result = new ExhibitionResultModel
                {
                    ErrorMessage = null,
                    IsSuccessful = true,
                    Exhibition = new ExhibitionDomainModel
                    {
                        ExhibitionId = deletedExhibition.ExhibitionId,
                        ExhibitionName = deletedExhibition.ExhibitionName,
                        AuditoriumId = deletedExhibition.AuditoriumId,
                        TypeOfExhibition = deletedExhibition.TypeOfExhibition,
                        StartTime = deletedExhibition.StartTime,
                        EndTime = deletedExhibition.EndTime

                    }
                };
                return result;
            }
        }

        public async Task<IEnumerable<ExhibitionDomainModel>> GetAllExhibitions()
        {
            var data = await _exhibitionRepository.GetAll();

            if(data == null)
            {
                return null;
            }
            List<ExhibitionDomainModel> list = new List<ExhibitionDomainModel>();

            ExhibitionDomainModel exhibitionModel;
            foreach (var item in data)
            {
                exhibitionModel = new ExhibitionDomainModel
                {
                    ExhibitionId = item.ExhibitionId,
                    ExhibitionName = item.ExhibitionName,
                    AuditoriumId = item.AuditoriumId,
                    TypeOfExhibition = item.TypeOfExhibition,
                    StartTime = item.StartTime,
                    EndTime = item.EndTime
                };
                list.Add(exhibitionModel);
            }return list;
        }

        public async Task<ExhibitionDomainModel> GetExhibitionByIdAsync(int id)
        {
            var data = await _exhibitionRepository.GetByIdAsync(id);

            if (data == null) return null;

            ExhibitionDomainModel result;
            result = new ExhibitionDomainModel
            {
                ExhibitionId = data.ExhibitionId,
                ExhibitionName = data.ExhibitionName,
                AuditoriumId = data.AuditoriumId,
                TypeOfExhibition = data.TypeOfExhibition,
                StartTime = data.StartTime,
                EndTime = data.EndTime
            };
            return result;
        }

        public Task<ExhibitionResultModel> UpdateExhibition()
        {
            throw new NotImplementedException();
        }
    }
}
