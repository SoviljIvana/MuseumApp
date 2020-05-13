using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class ExhibitionDomainModel
    {
        public int ExhibitionId { get; set; }
        public string ExhibitionName { get; set; }
        public int AuditoriumId { get; set; }
        public string About { get; set; }
        public string Picture { get; set; }
        public string TypeOfExhibition { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public virtual List<ExhibitDomainModel> Exhibits { get; set; }
    }
}
