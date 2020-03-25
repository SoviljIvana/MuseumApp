using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Exhibition
    {
        public int id { get; set; }
        public string excibitionName { get; set; }
        public int auditoriumId { get; set; }
        public string typeOfExhibition { get; set; }
        public DateTime startTime { get; set; }
        public DateTime endTime { get; set; }
    }
}
