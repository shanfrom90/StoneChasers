using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class RockLocationVM
    {
        public Rock Rock {get; set;}
        public Location Location { get; set; }

        [Required]
        public IFormFile ImageFile { get; set; }

        public UserRock UserRock { get; set; }
    }
}
