using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("exhibit")]

    public class ExhibitEntity
    {
        [Key]
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
