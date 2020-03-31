using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Exhibit
    {
        public int Id { get; set; }
        public int IdExhibition { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public string PicturePath { get; set; }
        public int AuditoriumId { get; set; }
        public int ExhibitionId { get; set; }
        public virtual Exhibition Exhibition { get; set; }
        public virtual ICollection<ExhibitTag> ExhibitionTags { get; set; }
    }
}
