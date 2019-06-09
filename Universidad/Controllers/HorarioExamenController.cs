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
    public class HorarioExamenController : Controller
    {
        private UContext db = new UContext();

        // GET: HorarioExamen
        public ActionResult Index()
        {
            var horarioExamen = db.HorarioExamen.Include(h => h.Aulas).Include(h => h.Profesor).Include(h => h.Turnos);
            return View(horarioExamen.ToList());
        }

        // GET: HorarioExamen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HorarioExamen horarioExamen = db.HorarioExamen.Find(id);
            if (horarioExamen == null)
            {
                return HttpNotFound();
            }
            return View(horarioExamen);
        }

        // GET: HorarioExamen/Create
        public ActionResult Create()
        {
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId");
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion");
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion");
            return View();
        }

        // POST: HorarioExamen/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HorarioExamenId,AulaId,ProfesorId,MateriaId,TurnoId,Fecha")] HorarioExamen horarioExamen)
        {
            if (ModelState.IsValid)
            {
                db.HorarioExamen.Add(horarioExamen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarioExamen.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarioExamen.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarioExamen.TurnoId);
            return View(horarioExamen);
        }

        // GET: HorarioExamen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HorarioExamen horarioExamen = db.HorarioExamen.Find(id);
            if (horarioExamen == null)
            {
                return HttpNotFound();
            }
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarioExamen.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarioExamen.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarioExamen.TurnoId);
            return View(horarioExamen);
        }

        // POST: HorarioExamen/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HorarioExamenId,AulaId,ProfesorId,MateriaId,TurnoId,Fecha")] HorarioExamen horarioExamen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horarioExamen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarioExamen.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarioExamen.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarioExamen.TurnoId);
            return View(horarioExamen);
        }

        // GET: HorarioExamen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HorarioExamen horarioExamen = db.HorarioExamen.Find(id);
            if (horarioExamen == null)
            {
                return HttpNotFound();
            }
            return View(horarioExamen);
        }

        // POST: HorarioExamen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HorarioExamen horarioExamen = db.HorarioExamen.Find(id);
            db.HorarioExamen.Remove(horarioExamen);
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
