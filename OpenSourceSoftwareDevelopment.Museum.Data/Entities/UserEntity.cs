using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    [Table("user")]

    public class UserEntity:IEntity
    {
        [Key]
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime YearOfBirth { get; set; }
        public virtual ICollection<TicketEntity> Tickets { get; set; }

        public int getId()
        {
            return UserId;
        }

        public int getType()
        {
            return 8;
        }
    }
}
