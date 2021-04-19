using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class Rock
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [RegularExpression("([^\\s]+(\\.(?i)(jpg|png|gif|bmp))$)")]
        public string Image { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
        public DateTime CreatedOn { get; set; }
       
        public string Serial { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        [System.Text.Json.Serialization.JsonIgnore]
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<UserRock> UserRocks { get; set; }



        public Rock()
        {

        }
    }
}
