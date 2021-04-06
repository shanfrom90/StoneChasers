using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class Rock
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime CreatedOn { get; set; }
        public string Serial { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Location> Locations { get; set; }

        public Rock()
        {

        }
    }
}
