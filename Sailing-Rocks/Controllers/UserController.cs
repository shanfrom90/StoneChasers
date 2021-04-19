﻿using Microsoft.AspNetCore.Http;
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
        public ActionResult Create(User model)
        {
            model.CreatedOn = DateTime.Now;

            userRepo.Create(model);

            ViewBag.Result = "You've successfuly created your profile. You Rock!";

            return RedirectToAction("Login", "User");
        }

        public ViewResult Details(string? message)
        {
            ViewBag.message = message;
            var UserId = HttpContext.Session.GetString("UserId");
            var user = userRepo.GetById(Convert.ToInt32(UserId));

            return View(user);
        }

        public ViewResult Update(int id)
        {
            var user = userRepo.GetById(id);

            return View(user);
        }

        [HttpPost]
        public ActionResult Update(User model)
        {
            userRepo.Update(model);

            ViewBag.Result = "You have updated your profile.";

            return RedirectToAction("Details","User");
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
            
            return Logout();
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(User model)
        {
            var response = userRepo.CheckLogin(model.UserName, model.Password);
            if (response.Result)
            {
                 
                HttpContext.Session.SetString("UserName", response.User.UserName);
                HttpContext.Session.SetString("UserId", response.User.Id.ToString());

                return RedirectToAction("Details", "User", new { id = response.User.Id });
            }
            else
            {
                ViewBag.ResultMessage = response.Message;
                return RedirectToAction("Create", "User");
            }
        }

        public ActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

        public ActionResult FoundRock(string serial)
        {
            var rock = userRepo.GetRockBySerial(serial);
            if(rock != null)
            {
                var sessionUserId = Convert.ToInt32(HttpContext.Session.GetString("UserId"));
                userRepo.RockFound(rock.UserId, rock.Id, sessionUserId);
            }
            else
            {
                return RedirectToAction("Details", new { message="Rock not found." }); 
            }
            return RedirectToAction("Details", "Rock", rock);
        }

    }
}
