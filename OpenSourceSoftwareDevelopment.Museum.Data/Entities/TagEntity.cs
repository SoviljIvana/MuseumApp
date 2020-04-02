using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class TagEntity
    {
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<ExhibitTagEntity> ExhibitTags { get; set; }
    }
}
