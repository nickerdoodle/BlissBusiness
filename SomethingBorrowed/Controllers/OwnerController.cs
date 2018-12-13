using SomethingBorrowed.DAL;
using SomethingBorrowed.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace SomethingBorrowed.Controllers
{
    public class OwnerController : Controller
    {
        private BridalContext db = new BridalContext();

        // GET: Owner
        public ActionResult Index()
        {
            return View(db.Owners.ToList());
        }

        public ActionResult Create()
        {
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateDesc");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Owner owner)
        {
            if (ModelState.IsValid == true)
            {
                db.Owners.Add(owner);
                db.SaveChanges();
                int id = owner.OwnerID;
                ViewBag.OwnerName = owner.OwnerFirstName + " " + owner.OwnerLastName;
                return View("ConfirmNewOwner");
            }
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateDesc");
            return View();
        }


        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owner owner = db.Owners.Find(id);
            if (owner == null)
            {
                return HttpNotFound();
            }
            
            ViewBag.StateID = new SelectList(db.States, "StateID", "StateDesc");
            return View(owner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Owner owner)
        {
            if (ModelState.IsValid == true)
            {
                db.Entry(owner).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(owner);
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owner owner = db.Owners.Find(id);
            if (owner == null)
            {
                return HttpNotFound();
            }
            return View(owner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            Owner owner = db.Owners.Find(id);
            db.Owners.Remove(owner);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Compounds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Owner owner = db.Owners.Find(id);
            if (owner == null)
            {
                return HttpNotFound();
            }
            return View(owner);
        }
    
    }
}