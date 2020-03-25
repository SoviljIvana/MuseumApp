using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class Exhibit
    {
        public int id { get; set; }
        public int idExhibition { get; set; }
        public string name { get; set; }
        public int year { get; set; }
        public string picturePath { get; set; }
        public int auditoriumId { get; set; }
        public int exhibitionId { get; set; }
    }
}
