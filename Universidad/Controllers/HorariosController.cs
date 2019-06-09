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
    public class HorariosController : Controller
    {
        private UContext db = new UContext();

        // GET: Horarios
        public ActionResult Index()
        {
            var horarios = db.Horarios.Include(h => h.Aulas).Include(h => h.Profesor).Include(h => h.Turnos);
            return View(horarios.ToList());
        }

        // GET: Horarios/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horarios horarios = db.Horarios.Find(id);
            if (horarios == null)
            {
                return HttpNotFound();
            }
            return View(horarios);
        }

        // GET: Horarios/Create
        public ActionResult Create()
        {
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId");
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion");
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion");
            return View();
        }

        // POST: Horarios/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HorarioId,AulaId,ProfesorId,MateriaId,TurnoId,Cupo")] Horarios horarios)
        {
            if (ModelState.IsValid)
            {
                db.Horarios.Add(horarios);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarios.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarios.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarios.TurnoId);
            return View(horarios);
        }

        // GET: Horarios/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horarios horarios = db.Horarios.Find(id);
            if (horarios == null)
            {
                return HttpNotFound();
            }
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarios.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarios.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarios.TurnoId);
            return View(horarios);
        }

        // POST: Horarios/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HorarioId,AulaId,ProfesorId,MateriaId,TurnoId,Cupo")] Horarios horarios)
        {
            if (ModelState.IsValid)
            {
                db.Entry(horarios).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AulaId = new SelectList(db.Aulas, "AulaId", "AulaId", horarios.AulaId);
            ViewBag.ProfesorId = new SelectList(db.Profesores, "ProfesorId", "Direccion", horarios.ProfesorId);
            ViewBag.TurnoId = new SelectList(db.Turnos, "TurnoId", "Descripcion", horarios.TurnoId);
            return View(horarios);
        }

        // GET: Horarios/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Horarios horarios = db.Horarios.Find(id);
            if (horarios == null)
            {
                return HttpNotFound();
            }
            return View(horarios);
        }

        // POST: Horarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Horarios horarios = db.Horarios.Find(id);
            db.Horarios.Remove(horarios);
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
