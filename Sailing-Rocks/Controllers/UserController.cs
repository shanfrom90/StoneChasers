using Microsoft.AspNetCore.Mvc;
using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Controllers
{
    public class UserController : Controller
    {

        IRepository<User> userRepo;

        public UserController(IRepository<User> userRepo)
        {
            this.userRepo = userRepo;
            
        }

        public ViewResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ViewResult Create(User model)
        {
            return View();
        }

 


        public IActionResult Index()
        {
            return View();
        }
    }
}
