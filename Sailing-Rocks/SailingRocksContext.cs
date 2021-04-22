using Sailing_Rocks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks
{
    public class SailingRocksContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Rock> Rocks { get; set; }
        public DbSet<Location> Locations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=SailingRocksDB_TEST;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString).UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Jason",
                    LastName = "Kepic",
                    Password = "password",
                    Image = "https://jak719.github.io/images/HS5.png",
                    Hometown = "Parma, OH",
                    Bio = "Software Developer",
                    UserName = "jak719",
                    Email = "jak719@gmail.com",
                    CreatedOn = DateTime.Now
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Eric",
                    LastName = "Faler",
                    Password = "123456",
                    Image = "https://emfaler.github.io/images/WCCI%20Headshot.jpg",
                    Hometown = "Fairview Park, OH",
                    Bio = "Software Developer",
                    UserName = "efaler",
                    Email = "efaler@gmail.com",
                    CreatedOn = DateTime.Now
                }, 
                
                new User()
                {
                    Id = 3,
                    FirstName = "Shannon",
                    LastName = "Adams",
                    Password = "123456",
                    Image = "https://avatars.githubusercontent.com/u/77690999?v=4",
                    Hometown = "Cincinnati, OH",
                    Bio = "Avid Hiker",
                    UserName = "shanfrom90",
                    Email = "shanfrom90@gmail.com",
                    CreatedOn = DateTime.Now
                },
                new User()
                {
                    Id = 4,
                    FirstName = "Tiah",
                    LastName = "Campbell",
                    Password = "123456",
                    Image = "https://media-exp1.licdn.com/dms/image/C4E03AQEIQiWhliy2Uw/profile-displayphoto-shrink_200_200/0/1614008492988?e=1624492800&v=beta&t=fravB8yvb_-EhFKcCa9e8KRIhPM870Zj2oFxVC7f_oc",
                    Hometown = "Cleveland, OH",
                    Bio = "Fitness Fiend",
                    UserName = "tiahRocks",
                    Email = "tiahC@gmail.com",
                    CreatedOn = DateTime.Now
                },
                new User()
                {
                    Id = 5,
                    FirstName = "JE",
                    LastName = "Woods",
                    Password = "123456",
                    Image = "https://media-exp1.licdn.com/dms/image/C4D03AQEw1N-X8JU9UA/profile-displayphoto-shrink_800_800/0/1614220067971?e=1624492800&v=beta&t=ZE3FWkoIKxRSyILQMOHsTh9omgK954adSnB9zgT2iac",
                    Hometown = "Cincinnati, OH",
                    Bio = "Artist",
                    UserName = "jeXex",
                    Email = "JE@gmail.com",
                    CreatedOn = DateTime.Now
                }

                );
            modelBuilder.Entity<Rock>().HasData(
                new Rock()
                {
                    Id = 1,
                    Name = "Rock Ness",
                    Image = "https://lh3.googleusercontent.com/pw/ACtC-3cf5OCoKweRgXmgpS1KMLb4OCgF-rUtKZ6gLvw8YQnih2e77W0lg6nLfuRimF9Slg7cRBfmqj3VR1qiSDaiEgZJqX2Xt6u5XPMfcwAjPfgYlIbo62_Xk-vBb-Y6JXkNgVtNTdp7xsgFiOooaxV-im0=w835-h626-no?authuser=0",
                    CreatedOn = DateTime.Now,
                    Serial = "BCDF2346",
                    UserId = 1,
                    Description = "Some folks don't believe in this rock, but I do."
                    
                },

                new Rock()
                {
                    Id = 2,
                    Name = "Love",
                    Image = "https://lh3.googleusercontent.com/pw/ACtC-3ek5FZPxYzihecIhMnfaY9hviSskhDJu7bMVUSBmoD2M7wy6EWutdNzmiOBzsxYrhHEDQ_R3-ydbQOGB5WRYZU_9wNnzVIqYmqjf1KvVHKVDlZY5wWFJw7qgETjkkqEdp4a4uOdzVyLz89-abhejTc=w470-h626-no?authuser=0",
                    CreatedOn = DateTime.Now,
                    Serial = "BCDH2346",
                    UserId = 2,
                    Description = "Love always wins!"

                },
                new Rock()
                {
                    Id = 3,
                    Name = "Dandelion",
                    Image = "https://lh3.googleusercontent.com/pw/ACtC-3ft7a2r_EJqEd2LvYmbRRYQmq4uFXDdGKZ9akut1XTqk7u_RWRaFD0c4CU-c1qQEI-3_eGD3ftiwIQHJqllRX8vBIZSdj8I-vr7RVOVNAHVsNeTqG7Qn1g6diCJ8MGO0cKpUvAyqkMtnwRXu_aVAG8=w470-h626-no?authuser=0",
                    CreatedOn = DateTime.Now,
                    Serial = "BCDG2346",
                    UserId = 3,
                    Description = "Make a Wish"

                },
                new Rock()
                {
                    Id = 4,
                    Name = "Heart You",
                    Image = "https://lh3.googleusercontent.com/pw/ACtC-3fCsuURb-SEfSvRvxctcRMhJvuFkZj2ENeNCcNKldagp9WcOz-v9lmfzz3D7SDsR7hMNS7-cnOES8OSSZINyaIkSeBZ5NfIxWcPh0-83YnaqGCWJLNg8qRvPTIKBqRUN3k35ena3xYfd1KLcCHqtEg=w470-h626-no?authuser=0",
                    CreatedOn = DateTime.Now,
                    Serial = "BCDP2346",
                    UserId = 4,
                    Description = "Make a Wish"

                }

                );
            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    Id = 1,
                    Lat = "41.363528",
                    Lng = "-81.851403",
                    RockId = 1,
                    LocatedOn = DateTime.Now,
                    LocationImage = "https://lh3.googleusercontent.com/pw/ACtC-3cNYh8lnJbZ-hcw9MxMrem_I3IZvFSCjylLUGKFgLk0rkPRWb9kI0rZGTNCppqzqO07AxRTlQYMlo7DDuCc2ddOioH-nY3Duj88aVYqnfz4XJs3I6kY6_uBFAEhlsIAKMPRg5LaA2mJBJUPIZBm_xk=w470-h626-no?authuser=0",
                    LocationName = "Coe Lake",
                    Comment = "10/10 Would pick up again."
                },
                new Location()
                {
                    Id = 2,
                    Lat = "41.435258",
                    Lng = "81.845719",
                    RockId = 2,
                    LocatedOn = DateTime.Now,
                    LocationImage = "https://lh3.googleusercontent.com/pw/ACtC-3fuuUDOXHlU4ZrfXr9wGBCA0e2goOoEd9dTcfaiAxCEAQO68FH_-JpNXUMHNHxsX-IFyL4gfpbbveiY0wRi8HdaGc7nZ-HCNIEUexgyA6owdsvudev5E8mJSCY4JuvwSdfgDQH0UThEMhQOq-OF09c=w470-h626-no?authuser=0",
                    LocationName = "Rocky River Reservation",
                    Comment = "Love on the earth!"
                },
                new Location()
                {
                    Id = 3,
                    Lat = "41.486700",
                    Lng = "-81.902125",
                    RockId = 3,
                    LocatedOn = DateTime.Now,
                    LocationImage = "https://lh3.googleusercontent.com/pw/ACtC-3cVXz2OU6RmroM460EY_88XA7tnBzeS82uuPOnOEZalDAuX_odTJGbS60FYyIut8-lzRNL58IB6CQsm4-_CNUlUhzWdjMxssOLZciDG31f0-LUOCWMT3Bk6W8d8hWDyZkYoAZ5I267Cf4gQEHUjaWVa=w470-h626-no?authuser=0",
                    LocationName = "Lake Erie",
                    Comment = "This made my day!"
                },
                new Location()
                {
                    Id = 4,
                    Lat = "41.29424235787053",
                    Lng = "-82.15200988091138",
                    RockId = 4,
                    LocatedOn = DateTime.Now,
                    LocationImage = "https://lh3.googleusercontent.com/pw/ACtC-3cSZgugu_nTsn7kUufw-G_IVKSFqePIMPbDHiA7n5XlatblZTQhLaZH0y0CVtTXtcMP69i564m_UZFcTyOH16HeUPTOR_u_cWBH3Ta-MI4c5NFmaDzRmH2w1rXNizvehZgSNgkG6-ZfkVCsNuDV3ws=w470-h626-no?authuser=0",
                    LocationName = "Carlisle Reservation",
                    Comment = "I love this rock so much!"
                },
                 new Location()
                 {
                     Id = 5,
                     Lat = "41.3639780269892",
                     Lng = "-81.85258535965691",
                     RockId = 4,
                     LocatedOn = DateTime.Now,
                     LocationImage = "https://lh3.googleusercontent.com/pw/ACtC-3dT4hvboHaq__uup5U6KvGq-vLMJXuilNM__lLUxFKh_X3uxGGj_i0oggaxRy5ahPekWJ1xYsZUf0t1laVPtjaVt1DpINz1Hy_ZN5UJBfm_jHJrWXRUHaoJFonmy9LdnLRAW8RCmTyCaSSaEFstfDg=w470-h626-no?authuser=0",
                     LocationName = "Coe Lake",
                     Comment = "Love for everyone!"
                 }

                );
            modelBuilder.Entity<UserRock>().HasData(
                new UserRock()
                {
                    Id = 1,
                    RockId = 1,
                    UserId = 2
                },

                new UserRock()
                {
                    Id = 2,
                    RockId = 2,
                    UserId = 1
                },
                new UserRock()
                {
                    Id = 3,
                    RockId = 3,
                    UserId = 4
                },
                new UserRock()
                {
                    Id = 4,
                    RockId = 4,
                    UserId = 5
                },
                new UserRock()
                {
                    Id = 5,
                    RockId = 4,
                    UserId = 1
                }
                 
            );
          



        }
    }
}
