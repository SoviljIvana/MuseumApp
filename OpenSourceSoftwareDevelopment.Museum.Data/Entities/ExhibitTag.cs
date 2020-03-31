using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class ExhibitTag
    {
        public int TagId { get; set; }
        public int ExhibitionId { get; set; }

        public virtual Tag Tag { get; set; }
        public virtual Exhibit Exhibit { get; set; }

    }
}
