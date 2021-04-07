using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class UserRock
    {
        public  int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int RockId { get; set; }
        public virtual Rock Rock { get; set; }
    }
}
