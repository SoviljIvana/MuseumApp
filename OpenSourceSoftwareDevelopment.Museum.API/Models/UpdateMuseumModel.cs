using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceSoftwareDevelopment.Museum.API.Models
{
    public class UpdateMuseumModel
    {
        public string Name { get; set; }
        public string StreetAndNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
