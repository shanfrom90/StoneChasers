using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Title { get; set; }
        public int RockId { get; set; }

        public virtual Rock Rock { get; set; }


    }
}
