using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Dominio;

namespace Universidad.Controllers
{
    public class CalificacionesController : Controller
    {
        private UContext db = new UContext();

        // GET: Calificaciones
        public ActionResult Index()
        {
            var calificaciones = db.Calificaciones.Include(c => c.Examenes);
            return View(calificaciones.ToList());
        }

        // GET: Calificaciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        // GET: Calificaciones/Create
        public ActionResult Create()
        {
            ViewBag.ExamenId = new SelectList(db.Examenes, "ExamenId", "ExamenId");
            return View();
        }

        // POST: Calificaciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CalificacionId,ExamenId,Calification")] Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Calificaciones.Add(calificaciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ExamenId = new SelectList(db.Examenes, "ExamenId", "ExamenId", calificaciones.ExamenId);
            return View(calificaciones);
        }

        // GET: Calificaciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.ExamenId = new SelectList(db.Examenes, "ExamenId", "ExamenId", calificaciones.ExamenId);
            return View(calificaciones);
        }

        // POST: Calificaciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CalificacionId,ExamenId,Calification")] Calificaciones calificaciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(calificaciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ExamenId = new SelectList(db.Examenes, "ExamenId", "ExamenId", calificaciones.ExamenId);
            return View(calificaciones);
        }

        // GET: Calificaciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            if (calificaciones == null)
            {
                return HttpNotFound();
            }
            return View(calificaciones);
        }

        // POST: Calificaciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Calificaciones calificaciones = db.Calificaciones.Find(id);
            db.Calificaciones.Remove(calificaciones);
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
