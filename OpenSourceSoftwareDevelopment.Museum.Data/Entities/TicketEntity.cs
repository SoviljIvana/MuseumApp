using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("ticket")]

    public class TicketEntity:IEntity
    {
        [Key]
        public int TicketId { get; set; }
        public int Payment { get; set; }
        public int ExhibitionId { get; set; }
        public int UserId { get; set; }
        public virtual ExhibitionEntity Exhibition { get; set; }
        public virtual UserEntity User { get; set; }

        public int getId()
        {
            return TicketId;
        }

        public int getType()
        {
            return 7;
        }
    }
}
