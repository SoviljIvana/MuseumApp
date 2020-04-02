using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.API.Models
{
    public class UpdateAuditoriumModel
    {
        public int MuseumId { get; set; }
        public string NameOfAuditorium { get; set; }
        public int NumberOfSeats { get; set; }
    }
}
