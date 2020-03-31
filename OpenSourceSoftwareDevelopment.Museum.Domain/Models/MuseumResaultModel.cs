using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
    public class MuseumResaultModel
    {
        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }

        public MuseumDomainModel Museum { get; set; }
    }
}
