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
    public class RegistroIngresoSalidasController : Controller
    {
        private EjercicioORMContext db = new EjercicioORMContext();

        // GET: RegistroIngresoSalidas
        public ActionResult Index()
        {
            return View(db.RegistroIngresoSalida.ToList());
        }

        // GET: RegistroIngresoSalidas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroIngresoSalida registroIngresoSalida = db.RegistroIngresoSalida.Find(id);
            if (registroIngresoSalida == null)
            {
                return HttpNotFound();
            }
            return View(registroIngresoSalida);
        }

        // GET: RegistroIngresoSalidas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistroIngresoSalidas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdRegistro,FechaHoraIngreso,FechaHoraSalida")] RegistroIngresoSalida registroIngresoSalida)
        {
            if (ModelState.IsValid)
            {
                db.RegistroIngresoSalida.Add(registroIngresoSalida);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registroIngresoSalida);
        }

        // GET: RegistroIngresoSalidas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroIngresoSalida registroIngresoSalida = db.RegistroIngresoSalida.Find(id);
            if (registroIngresoSalida == null)
            {
                return HttpNotFound();
            }
            return View(registroIngresoSalida);
        }

        // POST: RegistroIngresoSalidas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdRegistro,FechaHoraIngreso,FechaHoraSalida")] RegistroIngresoSalida registroIngresoSalida)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registroIngresoSalida).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registroIngresoSalida);
        }

        // GET: RegistroIngresoSalidas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistroIngresoSalida registroIngresoSalida = db.RegistroIngresoSalida.Find(id);
            if (registroIngresoSalida == null)
            {
                return HttpNotFound();
            }
            return View(registroIngresoSalida);
        }

        // POST: RegistroIngresoSalidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistroIngresoSalida registroIngresoSalida = db.RegistroIngresoSalida.Find(id);
            db.RegistroIngresoSalida.Remove(registroIngresoSalida);
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
