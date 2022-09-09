using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EjercicioORM1JoelGramajo.Data;
using EjercicioORM1JoelGramajo.Models;

namespace EjercicioORM1JoelGramajo.Controllers
{
    public class RegistroControlsController : Controller
    {
        private EjercicioORMContext db = new EjercicioORMContext();

        // GET: RegistroControls
        public ActionResult Index()
        {
            return View(db.RegistroControl.ToList());
        }

        // GET: RegistroControls/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroControl registroControl = db.RegistroControl.Find(id);
            if (registroControl == null)
            {
                return HttpNotFound();
            }
            return View(registroControl);
        }

        // GET: RegistroControls/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroControls/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRegistroControl,Fecha,Informacion")] RegistroControl registroControl)
        {
            if (ModelState.IsValid)
            {
                db.RegistroControl.Add(registroControl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registroControl);
        }

        // GET: RegistroControls/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroControl registroControl = db.RegistroControl.Find(id);
            if (registroControl == null)
            {
                return HttpNotFound();
            }
            return View(registroControl);
        }

        // POST: RegistroControls/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRegistroControl,Fecha,Informacion")] RegistroControl registroControl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroControl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registroControl);
        }

        // GET: RegistroControls/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroControl registroControl = db.RegistroControl.Find(id);
            if (registroControl == null)
            {
                return HttpNotFound();
            }
            return View(registroControl);
        }

        // POST: RegistroControls/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroControl registroControl = db.RegistroControl.Find(id);
            db.RegistroControl.Remove(registroControl);
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
