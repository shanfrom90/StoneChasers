using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [Display(Name = "Name")]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Sailing Rocks Member Since")]
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Rock> Rocks { get; set; }
        public virtual ICollection<UserRock> UserRocks { get; set; }

        public User()
        {
            
        }

        //add an empty constructor?







    }
}
