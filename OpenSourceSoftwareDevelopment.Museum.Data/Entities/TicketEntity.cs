using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class TicketEntity
    {
        public int TicketId { get; set; }
        public int Payment { get; set; }
        public int ExhibitionId { get; set; }
        public int UserId { get; set; }
        public virtual ExhibitionEntity Exhibition { get; set; }
        public virtual UserEntity User { get; set; }
    }
}
