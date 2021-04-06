using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }

        //add a default image?
        public string Image { get; set; }

        public string Hometown { get; set; }
        public string Bio { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Rock> Rocks { get; set; }

        public User()
        {
            
        }

        //add an empty constructor?







    }
}
