﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class ExhibitionDomainModel
    {
        public int Id { get; set; }
        public string ExcibitionName { get; set; }
        public int AuditoriumId { get; set; }
        public string TypeOfExhibition { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
    }
}