using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sailing_Rocks.Controllers
{
    public class UserController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;

        IRepository<User> userRepo;

        public UserController(IRepository<User> userRepo, IWebHostEnvironment hostEnvironment)
        {
            this.userRepo = userRepo;
            this._hostEnvironment = hostEnvironment;


        }

        public ViewResult Create()
        {
            return View(new User());
        }

        [HttpPost]
        public ActionResult Create(User model)
        {
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            model.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            model.Image = "/ContentImages/" + model.Image;
            string path = Path.Combine(wwwRootPath + "/ContentImages", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                model.ImageFile.CopyTo(fileStream);
            }

            model.CreatedOn = DateTime.Now;

            userRepo.Create(model);

            ViewBag.Result = "You've successfuly created your profile. You Rock!";

            return RedirectToAction("Login", "User");
        }


        public ViewResult Details(string? message, int? id)
        {
            ViewBag.message = message;
            User user;
            if(id == null)
            {
            var UserId = HttpContext.Session.GetString("UserId");
            user = userRepo.GetById(Convert.ToInt32(UserId));
            }
            else
            {
                user = userRepo.GetById((int)id);
            }
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
            string wwwRootPath = _hostEnvironment.WebRootPath;
            string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
            string extension = Path.GetExtension(model.ImageFile.FileName);
            model.Image = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
            model.Image = "/ContentImages/" + model.Image;
            string path = Path.Combine(wwwRootPath + "/ContentImages", fileName);
            using (var fileStream = new FileStream(path, FileMode.Create))
            {
                model.ImageFile.CopyTo(fileStream);
            }

            userRepo.Update(model);

            ViewBag.Result = "You have updated your profile.";

            return RedirectToAction("Details","User");
        }


        //public ViewResult Delete(int id)
        //{
        //    var user = userRepo.GetById(id);

        //    return View(user);
        //}

        //[HttpPost]
        //public ActionResult Delete(User model)
        //{
        //    SailingRocksContext db = new SailingRocksContext();
        //    var user = db.Users.Find(model.Id);

        //    foreach (var userRock in user.UserRocks)
        //    {
        //        userRock.User = null;
        //    }

        //    var rocks = db.Rocks.Where(r => r.UserId == model.Id).ToList();

        //    foreach (var rock in rocks)
        //    {
        //        rock.UserRocks.Clear();
        //    }
        //    db.SaveChanges();
        //    db.Rocks.RemoveRange(rocks);
        //    db.Users.Remove(user);
        //    db.SaveChanges();


        //    return Logout();
        //}

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
