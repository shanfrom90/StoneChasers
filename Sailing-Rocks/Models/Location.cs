using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class Location
    {
        public int Id { get; set; }

        [Display(Name = "Enter Latitude:")]
        public string Lat { get; set; }

        [Display(Name = "Enter Longitude:")]
        public string Lng { get; set; }

        public int RockId { get; set; }
        public virtual Rock rock { get; set; }

        [Display(Name = "Located On:")]
        public DateTime LocatedOn { get; set; }
        public string LocationImage { get; set; }

        public Location()
        {

        }
    }
}
