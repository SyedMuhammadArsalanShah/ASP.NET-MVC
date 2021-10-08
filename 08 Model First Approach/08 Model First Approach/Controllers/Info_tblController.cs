using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using _08_Model_First_Approach.Models;

namespace _08_Model_First_Approach.Controllers
{
    public class Info_tblController : Controller
    {
        private Model1Container1 db = new Model1Container1();

        // GET: Info_tbl
        public ActionResult Index()
        {
            return View(db.Info_tbl.ToList());
        }

        // GET: Info_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info_tbl info_tbl = db.Info_tbl.Find(id);
            if (info_tbl == null)
            {
                return HttpNotFound();
            }
            return View(info_tbl);
        }

        // GET: Info_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Info_tbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Gender")] Info_tbl info_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Info_tbl.Add(info_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(info_tbl);
        }

        // GET: Info_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info_tbl info_tbl = db.Info_tbl.Find(id);
            if (info_tbl == null)
            {
                return HttpNotFound();
            }
            return View(info_tbl);
        }

        // POST: Info_tbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Gender")] Info_tbl info_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(info_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(info_tbl);
        }

        // GET: Info_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Info_tbl info_tbl = db.Info_tbl.Find(id);
            if (info_tbl == null)
            {
                return HttpNotFound();
            }
            return View(info_tbl);
        }

        // POST: Info_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Info_tbl info_tbl = db.Info_tbl.Find(id);
            db.Info_tbl.Remove(info_tbl);
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
