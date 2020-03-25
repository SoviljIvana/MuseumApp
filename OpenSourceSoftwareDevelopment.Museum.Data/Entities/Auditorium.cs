using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Auditorium
    {
        public int AuditoriumId { get; set; }
        public int MuseumId { get; set; }
        public string NameOfAuditorium { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
