using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("tag")]

    public class TagEntity
    {
        [Key]
        public int TagId { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<ExhibitTagEntity> ExhibitTags { get; set; }

    }
}
