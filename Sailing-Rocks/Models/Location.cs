using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string Lat { get; set; }
        public string Lng { get; set; }
        public int RockId { get; set; }
        public virtual Rock rock { get; set; }
        public DateTime LocatedOn { get; set; }
        public bool IsCurrent { get; set; }

        public Location()
        {

        }
    }
}
