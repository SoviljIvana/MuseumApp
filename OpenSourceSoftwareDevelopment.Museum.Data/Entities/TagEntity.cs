﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public class TagEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public virtual ICollection<ExhibitTagEntity> ExhibitionTags { get; set; }
    }
}