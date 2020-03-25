using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Auditorium
    {
        public int auditoriumId { get; set; }
        public int museumId { get; set; }
        public string nameOfAuditorium { get; set; }
        public int numberOfSeats { get; set; }
    }
}
