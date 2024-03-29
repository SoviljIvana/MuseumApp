﻿using OpenSourceSoftwareDevelopment.Museum.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class MuseumDomainModel
    {
        public int MuseumId { get; set; }
        public string Name { get; set; }
        public string StreetAndNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<AuditoriumDomainModel> AuditoriumDomainModels { get; set; }


    }
}
