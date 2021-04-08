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
   
    public class LocationController : Controller
    {
        IRepository<Location> locationRepo;
        public LocationController(IRepository<Location> locationRepo)
        {
            this.locationRepo = locationRepo;
        }
        // GET: LocationController
        public ActionResult Index()
        {
            var locationList = locationRepo.GetAll();
            return View(locationList);
        }

        // GET: LocationController/Details/5
        public ActionResult Details(int id)
        {
            var location = locationRepo.GetById(id);
            return View(location);
        }


        //can get rid of this function if location create is in rock details
        // GET: LocationController/Create
        public ViewResult Create()
        {   
            //may need list of rocks?
            return View(new Location());
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RockLocationVM model)
        {

            //list of rocks
            locationRepo.Create(model.Location);
           
            return RedirectToAction("Details", "Rock", new {id = model.Location.RockId});
            
        }

        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            var location = locationRepo.GetById(id);
            //list of rocks
            return View(location);
        }

        // POST: LocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Location model)
        { //list of rocks
            locationRepo.Update(model);
            ViewBag.Result = "You hae successfully edited this location";
            return View(model);
        }

        // GET: LocationController/Delete/5
        public ActionResult Delete(int id)
        {
            var location = locationRepo.GetById(id);
            locationRepo.Delete(location);
            return RedirectToAction("Index");
        }

        // POST: LocationController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            //do we need a DELETE post?
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
