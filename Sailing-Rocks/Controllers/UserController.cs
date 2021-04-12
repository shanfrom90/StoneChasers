using Microsoft.AspNetCore.Http;
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

            return RedirectToAction("Login", "User", new { id = model.Id });
            //return RedirectToAction("Details", "User" , new {id = model.Id}); 
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
                //add session
                HttpContext.Session.SetString("Username", response.User.UserName);

                return RedirectToAction("Index", "Dashboard");
            }
            else
            {
                ViewBag.ResultMessage = response.Message;
                return View(model);
            }
        }

    }
}
