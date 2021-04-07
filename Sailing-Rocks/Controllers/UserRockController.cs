using Microsoft.AspNetCore.Mvc;
using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Controllers
{
    public class UserRockController : Controller
    {
        IRepository<UserRock> userRockRepo;
        public UserRockController(IRepository<UserRock> userRockRepo)
        {
            this.userRockRepo = userRockRepo;
        }


        
    }
}
