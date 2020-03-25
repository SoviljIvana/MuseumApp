using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class User
    {
        public int userId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public DateTime yearOfBirth { get; set; }
    }
}
