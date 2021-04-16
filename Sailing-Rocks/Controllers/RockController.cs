using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sailing_Rocks.Models;
using Sailing_Rocks.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Session;
using Newtonsoft.Json;
using Sailing_Rocks.Helpers;

namespace Sailing_Rocks.Controllers
{
    public class RockController : Controller
    {
        IRepository<Rock> rockRepo;
        public RockController(IRepository<Rock> rockRepo)
        {
            this.rockRepo = rockRepo;
        }

        //we are not displaying and index of rocks

        // GET: RockController
        //public ViewResult Index()
        //{
        //    return View();
        //}

        // GET: RockController/Details/5
        public ViewResult Details(int id)
        {
            var rock = rockRepo.GetById(id);
            return View(new RockLocationVM() { Rock = rock, Location = new Location() { RockId = id } });
        }

        // GET: RockController/Create
        public ViewResult Create() {

            var UserId =  HttpContext.Session.GetString("UserId");
            

            return View(new Rock() { UserId = Convert.ToInt32(UserId), CreatedOn = DateTime.Now });
        }

        // POST: RockController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rock model)
        {
            model.Serial = rockRepo.GenerateSerial(8);
            rockRepo.Create(model);
            return RedirectToAction("Details", "Rock", new { id = model.Id });
        }

        // GET: RockController/Edit/5
        public ActionResult Edit(int id)
        {
            var rock = rockRepo.GetById(id);
            var UserId = Int32.Parse(HttpContext.Session.GetString("UserId"));
            if(rock.UserId == UserId)
            {
                return View(rock);
            }
            else
            {
                return RedirectToAction("Details", "User", new { id = UserId });
            }

        }

        // POST: RockController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Rock model)
        {
            rockRepo.Update(model);
            return View(model);
        }

        public JsonResult GetRockLocation(int id)
        {
            var rock = rockRepo.GetById(id);

            return Json(JsonConvert.SerializeObject(rock.Locations, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        public JsonResult GetRockLocationBySerial(string serial)
        {
            var rock = rockRepo.GetRockBySerial(serial);

            return Json(JsonConvert.SerializeObject(rock.Locations, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));
        }

        //users do not have ability to delete rocks

        // GET: RockController/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: RockController/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}
