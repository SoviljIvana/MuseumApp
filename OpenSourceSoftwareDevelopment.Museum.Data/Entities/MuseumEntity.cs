﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("museum")]

    public class MuseumEntity
    {
        [Key]
        public int MuseumId { get; set; }
        public string Name { get; set; }
        public string StreetAndNumber { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public virtual ICollection<AuditoriumEntity> Auditoriums { get; set; }

    }
}
