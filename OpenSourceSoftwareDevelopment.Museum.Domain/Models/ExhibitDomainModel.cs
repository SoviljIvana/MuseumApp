using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class ExhibitDomainModel
    {
        public int Id { get; set; }
        public int IdExhibition { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string PicturePath { get; set; }
        public int AuditoriumId { get; set; }
        public int ExhibitionId { get; set; }
    }
}
