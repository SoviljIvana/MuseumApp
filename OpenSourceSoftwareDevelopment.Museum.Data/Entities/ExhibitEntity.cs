using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class ExhibitEntity
    {
        public int ExhibitId { get; set; }
        public int ExhibitionId { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string PicturePath { get; set; }
        public int AuditoriumId { get; set; }
        public virtual ExhibitionEntity Exhibition { get; set; }
        public virtual ICollection<ExhibitTagEntity> ExhibitTags { get; set; }
    }
}
