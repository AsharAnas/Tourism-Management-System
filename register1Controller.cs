using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication19.Models;

namespace WebApplication19.Controllers
{
    public class register1Controller : Controller
    {
        private projectEntities db = new projectEntities();

        // GET: /register1/
        public ActionResult Index()
        {

            var register1 = db.register1.Include(r => r.package);
            return View(register1.ToList());
        }

        // GET: /register1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            return View(register1);
        }

        // GET: /register1/Create
        public ActionResult Create()
        {

            ViewBag.packages = new SelectList(db.packages, "id", "packages");
            return View();
        }
     
        // POST: /register1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="id,firstName,lastName,gender,age,email,phoneno,address,city,packages,countryTogo,date,payment")] register1 register1)
        {
            if (ModelState.IsValid)
            {
                
                
                db.register1.Add(register1);
                db.SaveChanges();
                return RedirectToAction("Sucess","register1");
            }

            ViewBag.packages = new SelectList(db.packages, "id", "packages", register1.packages);
            return View(register1);
        }

        // GET: /register1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            ViewBag.packages = new SelectList(db.packages, "id", "packages", register1.packages);
            return View(register1);
        }

        // POST: /register1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="id,firstName,lastName,gender,age,email,phoneno,address,city,packages,countryTogo,date,payment")] register1 register1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(register1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.packages = new SelectList(db.packages, "id", "packages", register1.packages);
            return View(register1);
        }

        // GET: /register1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            register1 register1 = db.register1.Find(id);
            if (register1 == null)
            {
                return HttpNotFound();
            }
            return View(register1);
        }

        // POST: /register1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            register1 register1 = db.register1.Find(id);
            db.register1.Remove(register1);
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
        public ActionResult Sucess()
        {
            return View();
        }

    }
}
