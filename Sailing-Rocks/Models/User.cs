﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Sailing_Rocks.Helpers;

namespace Sailing_Rocks.Models
{
    public class User
    {
        private string _firstName;
        private string _password;
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {

                if (String.IsNullOrEmpty(value))
                {
                    _firstName = "Stone";
                }
                else
                {
                   
                    _firstName = value;
                }
            }
        }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [MinLength(6)]
        public string Password
        {
            get { return _password; }
            set
            {
                _password = Helper.EncryptPassword(value);
            }
        }

        public string Image { get; set; }

        [NotMapped]
        [DisplayName("Upload File")]
        [Required]
        public IFormFile ImageFile { get; set; }

        public string Hometown { get; set; }
        public string Bio { get; set; }
        [Display(Name = "Username")]
        [Required]
        public string UserName { get; set; }
        public string Email { get; set; }
        [Display(Name = "Sailing Rocks Member Since")]
        public DateTime CreatedOn { get; set; }
        public virtual ICollection<Rock> Rocks { get; set; }
        public virtual ICollection<UserRock> UserRocks { get; set; }

        public User()
        {
            
        }

        







    }
}
