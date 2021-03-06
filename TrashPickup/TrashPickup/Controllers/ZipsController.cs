﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TrashPickup.Models;

namespace TrashPickup.Controllers
{
    public class ZipsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Zips
        public ActionResult Index()
        {
            return View(db.Zip.ToList());
        }

        // GET: Zips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zip zip = db.Zip.Find(id);
            if (zip == null)
            {
                return HttpNotFound();
            }
            return View(zip);
        }

        // GET: Zips/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Zipcode")] Zip zip)
        {
            if (ModelState.IsValid)
            {
                db.Zip.Add(zip);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(zip);
        }

        // GET: Zips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zip zip = db.Zip.Find(id);
            if (zip == null)
            {
                return HttpNotFound();
            }
            return View(zip);
        }

        // POST: Zips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Zipcode")] Zip zip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(zip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(zip);
        }

        // GET: Zips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Zip zip = db.Zip.Find(id);
            if (zip == null)
            {
                return HttpNotFound();
            }
            return View(zip);
        }

        // POST: Zips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Zip zip = db.Zip.Find(id);
            db.Zip.Remove(zip);
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
