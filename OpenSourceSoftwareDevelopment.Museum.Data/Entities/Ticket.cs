using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Ticket
    {
        public int ticketId { get; set; }
        public int payment { get; set; }
        public int exhibitionId { get; set; }
        public int userId { get; set; }
    }
}
