using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SomethingBorrowed.DAL;
using SomethingBorrowed.Models;

namespace SomethingBorrowed.Controllers
{
    public class DressesController : Controller
    {
        private BridalContext db = new BridalContext();

        // GET: Dresses
        public ActionResult Index()
        {
            var dresses = db.Dresses.Include(d => d.DressSize).Include(d => d.Owner);
            return View(dresses.ToList());
        }

        // GET: Dresses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dress dress = db.Dresses.Find(id);
            if (dress == null)
            {
                return HttpNotFound();
            }
            return View(dress);
        }

        // GET: Dresses/Create
        public ActionResult Create()
        {
            ViewBag.DressSizeID = new SelectList(db.DressSizes, "DressSizeID", "DressSizeID");
            ViewBag.OwnerID = new SelectList(db.Owners, "OwnerID", "OwnerFirstName");
            return View();
        }

        // POST: Dresses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "dressID,OwnerID,DressDesigner,DressYear,DressColor,DressPricePaid,DressSizeID")] Dress dress)
        {
            if (ModelState.IsValid)
            {
                db.Dresses.Add(dress);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DressSizeID = new SelectList(db.DressSizes, "DressSizeID", "DressSizeDesc", dress.DressSizeID);
            ViewBag.OwnerID = new SelectList(db.Owners, "OwnerID", "OwnerFirstName", dress.OwnerID);
            return View(dress);
        }

        // GET: Dresses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dress dress = db.Dresses.Find(id);
            if (dress == null)
            {
                return HttpNotFound();
            }
            ViewBag.DressSizeID = new SelectList(db.DressSizes, "DressSizeID", "DressSizeDesc", dress.DressSizeID);
            ViewBag.OwnerID = new SelectList(db.Owners, "OwnerID", "OwnerFirstName", dress.OwnerID);
            return View(dress);
        }

        // POST: Dresses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "dressID,OwnerID,DressDesigner,DressYear,DressColor,DressPricePaid,DressSizeID")] Dress dress)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dress).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DressSizeID = new SelectList(db.DressSizes, "DressSizeID", "DressSizeID", dress.DressSizeID);
            ViewBag.OwnerID = new SelectList(db.Owners, "OwnerID", "OwnerFirstName", dress.OwnerID);
            return View(dress);
        }

        // GET: Dresses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Dress dress = db.Dresses.Find(id);
            if (dress == null)
            {
                return HttpNotFound();
            }
            return View(dress);
        }

        // POST: Dresses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Dress dress = db.Dresses.Find(id);
            db.Dresses.Remove(dress);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
