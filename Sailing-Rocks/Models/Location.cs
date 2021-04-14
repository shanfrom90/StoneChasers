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
        [System.Text.Json.Serialization.JsonIgnore]

        public virtual Rock rock { get; set; }

        [Display(Name = "Located On:")]
        public DateTime LocatedOn { get; set; }

        [Display(Name = "Location Name:")]
        public string LocationName { get; set; }
        
        public string Comment { get; set; }

        [Display(Name = "Location Image:")]
        public string LocationImage { get; set; }

        public Location()
        {

        }
    }
}
