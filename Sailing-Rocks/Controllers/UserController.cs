﻿using Microsoft.AspNetCore.Mvc;
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
            model.CreatedOn = DateTime.Now;

            userRepo.Create(model);

            ViewBag.Result = "You've successfuly created your profile. You Rock!";

            return View(model); 
        }

        public ViewResult Details(int id)
        {
            var user = userRepo.GetById(id);

            return View(user);
        }

        public ViewResult Update(int id)
        {
            var user = userRepo.GetById(id);

            return View(user);
        }

        [HttpPost]
        public ViewResult Update(User model)
        {
            userRepo.Update(model);

            ViewBag.Result = "You have updated your profile.";

            return View(model);
        }


        public ViewResult Delete(int id)
        {
            var user = userRepo.GetById(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(User model)
        {
            userRepo.Delete(model);

            return RedirectToAction("Create");
        }
                        
    }
}
