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
                    Email = "jkepic19@gmail.com",
                    CreatedOn = DateTime.Now
                }
                );
            modelBuilder.Entity<Rock>().HasData(
                new Rock()
                {
                    Id = 1,
                    Name = "Dwyane",
                    Image = "https://prowrestling.fandom.com/wiki/The_Rock",
                    CreatedOn = DateTime.Now,
                    Serial = "testSerial",
                    UserId = 1
                }
                );
            modelBuilder.Entity<Location>().HasData(
                new Location()
                {
                    Id = 1,
                    Lat = "41.52906515532968",
                    Lng = "-81.65136941810817",
                    RockId = 1,
                    LocatedOn = DateTime.Now,
                    IsCurrent = true
                }
                );
            modelBuilder.Entity<UserRock>().HasData(
                new UserRock()
                {
                    Id = 1,
                    RockId = 1,
                    UserId = 1
                }
            );



        }
    }
}
