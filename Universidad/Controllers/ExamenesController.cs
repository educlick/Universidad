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
    public class ExamenesController : Controller
    {
        private UContext db = new UContext();

        // GET: Examenes
        public ActionResult Index()
        {
            var examenes = db.Examenes.Include(e => e.HorarioExamenes);
            return View(examenes.ToList());
        }

        // GET: Examenes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examenes examenes = db.Examenes.Find(id);
            if (examenes == null)
            {
                return HttpNotFound();
            }
            return View(examenes);
        }

        // GET: Examenes/Create
        public ActionResult Create()
        {
            ViewBag.HorarioExamenId = new SelectList(db.HorarioExamen, "HorarioExamenId", "HorarioExamenId");
            return View();
        }

        // POST: Examenes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ExamenId,InscripcionId,HorarioExamenId,Fecha")] Examenes examenes)
        {
            if (ModelState.IsValid)
            {
                db.Examenes.Add(examenes);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HorarioExamenId = new SelectList(db.HorarioExamen, "HorarioExamenId", "HorarioExamenId", examenes.HorarioExamenId);
            return View(examenes);
        }

        // GET: Examenes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examenes examenes = db.Examenes.Find(id);
            if (examenes == null)
            {
                return HttpNotFound();
            }
            ViewBag.HorarioExamenId = new SelectList(db.HorarioExamen, "HorarioExamenId", "HorarioExamenId", examenes.HorarioExamenId);
            return View(examenes);
        }

        // POST: Examenes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ExamenId,InscripcionId,HorarioExamenId,Fecha")] Examenes examenes)
        {
            if (ModelState.IsValid)
            {
                db.Entry(examenes).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HorarioExamenId = new SelectList(db.HorarioExamen, "HorarioExamenId", "HorarioExamenId", examenes.HorarioExamenId);
            return View(examenes);
        }

        // GET: Examenes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Examenes examenes = db.Examenes.Find(id);
            if (examenes == null)
            {
                return HttpNotFound();
            }
            return View(examenes);
        }

        // POST: Examenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Examenes examenes = db.Examenes.Find(id);
            db.Examenes.Remove(examenes);
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
