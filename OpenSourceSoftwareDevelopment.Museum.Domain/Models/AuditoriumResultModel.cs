using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class AuditoriumResultModel
    {
        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }
        public AuditoriumDomainModel Auditorium { get; set; }

    }
}
