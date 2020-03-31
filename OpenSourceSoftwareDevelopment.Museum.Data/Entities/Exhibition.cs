using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Exhibition
    {
        public int Id { get; set; }
        public string ExcibitionName { get; set; }
        public int AuditoriumId { get; set; }
        public string TypeOfExhibition { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public virtual Auditorium Auditorium { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public virtual ICollection<Exhibit> Exhibits { get; set; }
    }
}
