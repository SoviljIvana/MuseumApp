using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
   public class Museum
    {
        public int museumId { get; set; }
        public string name { get; set; }
        public string streetAndNumber { get; set; }
        public string city { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
}
