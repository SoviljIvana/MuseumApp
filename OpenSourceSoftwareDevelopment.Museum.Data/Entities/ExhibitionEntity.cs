using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("exhibition")]

    public class ExhibitionEntity
    {
        [Key]
        public int ExhibitionId { get; set; }
        public string ExcibitionName { get; set; }
        public int AuditoriumId { get; set; }
        public string TypeOfExhibition { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual AuditoriumEntity Auditorium { get; set; }
        public virtual ICollection<TicketEntity> Tickets { get; set; }
        public virtual ICollection<ExhibitEntity> Exhibits { get; set; }
    }
}
