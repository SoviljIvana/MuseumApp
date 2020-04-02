using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class ExhibitTagEntity
    {
        public int TagId { get; set; }
        public int ExhibitId { get; set; }
        public virtual TagEntity Tag { get; set; }
        public virtual ExhibitEntity Exhibit { get; set; }

    }
}
