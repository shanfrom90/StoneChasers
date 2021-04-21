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
   
    public class LocationController : Controller
    {
        private readonly IWebHostEnvironment _hostEnvironment;
        IRepository<Location> locationRepo;
        public LocationController(IRepository<Location> locationRepo, IWebHostEnvironment hostEnvironment)
        {
            this.locationRepo = locationRepo;
            this._hostEnvironment = hostEnvironment;
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
           
            return View(new Location());
        }

        // POST: LocationController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(RockLocationVM model)
        { 
            if(model.ImageFile == null)
            {
                return RedirectToAction("Create");
            }
            else
            {
                string wwwRootPath = _hostEnvironment.WebRootPath;
                string fileName = Path.GetFileNameWithoutExtension(model.ImageFile.FileName);
                string extension = Path.GetExtension(model.ImageFile.FileName);

                model.Location.LocationImage = fileName = fileName + DateTime.Now.ToString("yymmssfff") + extension;
                model.Location.LocationImage = "/ContentImages/" + model.Location.LocationImage;
                string path = Path.Combine(wwwRootPath + "/ContentImages", fileName);
                using (var fileStream = new FileStream(path, FileMode.Create))
                {
                    model.ImageFile.CopyTo(fileStream);
                }

                locationRepo.Create(model.Location);
                return RedirectToAction("Details", "Rock", new { id = model.Location.RockId, LocatedOn = DateTime.Now });

            }

        }

        // GET: LocationController/Edit/5
        public ActionResult Edit(int id)
        {
            var location = locationRepo.GetById(id);
           
            return View(location);
        }

        // POST: LocationController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Location model)
        { 
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
