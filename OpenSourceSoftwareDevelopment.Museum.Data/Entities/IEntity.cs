using System;
using System.Collections.Generic;
using System.Text;

namespace OpenSourceSoftwareDevelopment.Museum.Data.Entities
{
    public interface IEntity
    {
        public int getId();
        public int getType();
    }
}
