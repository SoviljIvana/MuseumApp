using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Domain.Models
{
   public class ExhibitResultModel
    {
        public ExhibitDomainModel Exhibit { get; set; }

        public bool IsSuccessful { get; set; }

        public string ErrorMessage { get; set; }
    }
}
