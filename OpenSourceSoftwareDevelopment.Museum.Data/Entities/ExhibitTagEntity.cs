using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("exhibit")]

    public class ExhibitTagEntity:IEntity
    {
    
        public int TagId { get; set; }
        [Key]
        public int ExhibitId { get; set; }
        public virtual TagEntity Tag { get; set; }
        public virtual ExhibitEntity Exhibit { get; set; }

        public int getId()
        {
            return TagId;
        }

        public int getType()
        {
            return 4;
        }
    }
}
