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
    public class InscripcionesController : Controller
    {
        private UContext db = new UContext();

        // GET: Inscripciones
        public ActionResult Index()
        {
            var inscripciones = db.Inscripciones.Include(i => i.Horarioes).Include(i => i.MallaAlumnoes).Include(i => i.Matriculaes);
            return View(inscripciones.ToList());
        }

        // GET: Inscripciones/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripciones inscripciones = db.Inscripciones.Find(id);
            if (inscripciones == null)
            {
                return HttpNotFound();
            }
            return View(inscripciones);
        }

        // GET: Inscripciones/Create
        public ActionResult Create()
        {
            ViewBag.HorarioId = new SelectList(db.Horarios, "HorarioId", "HorarioId");
            ViewBag.MallaaluId = new SelectList(db.MallaAlumnos, "MallaaluId", "MallaaluId");
            ViewBag.MatriculaId = new SelectList(db.Matriculas, "MatriculaId", "MatriculaId");
            return View();
        }

        // POST: Inscripciones/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdInscripcion,AlumnoId,MatriculaId,MallaaluId,HorarioId,Fecha")] Inscripciones inscripciones)
        {
            if (ModelState.IsValid)
            {
                db.Inscripciones.Add(inscripciones);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.HorarioId = new SelectList(db.Horarios, "HorarioId", "HorarioId", inscripciones.HorarioId);
            ViewBag.MallaaluId = new SelectList(db.MallaAlumnos, "MallaaluId", "MallaaluId", inscripciones.MallaaluId);
            ViewBag.MatriculaId = new SelectList(db.Matriculas, "MatriculaId", "MatriculaId", inscripciones.MatriculaId);
            return View(inscripciones);
        }

        // GET: Inscripciones/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripciones inscripciones = db.Inscripciones.Find(id);
            if (inscripciones == null)
            {
                return HttpNotFound();
            }
            ViewBag.HorarioId = new SelectList(db.Horarios, "HorarioId", "HorarioId", inscripciones.HorarioId);
            ViewBag.MallaaluId = new SelectList(db.MallaAlumnos, "MallaaluId", "MallaaluId", inscripciones.MallaaluId);
            ViewBag.MatriculaId = new SelectList(db.Matriculas, "MatriculaId", "MatriculaId", inscripciones.MatriculaId);
            return View(inscripciones);
        }

        // POST: Inscripciones/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdInscripcion,AlumnoId,MatriculaId,MallaaluId,HorarioId,Fecha")] Inscripciones inscripciones)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inscripciones).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.HorarioId = new SelectList(db.Horarios, "HorarioId", "HorarioId", inscripciones.HorarioId);
            ViewBag.MallaaluId = new SelectList(db.MallaAlumnos, "MallaaluId", "MallaaluId", inscripciones.MallaaluId);
            ViewBag.MatriculaId = new SelectList(db.Matriculas, "MatriculaId", "MatriculaId", inscripciones.MatriculaId);
            return View(inscripciones);
        }

        // GET: Inscripciones/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Inscripciones inscripciones = db.Inscripciones.Find(id);
            if (inscripciones == null)
            {
                return HttpNotFound();
            }
            return View(inscripciones);
        }

        // POST: Inscripciones/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Inscripciones inscripciones = db.Inscripciones.Find(id);
            db.Inscripciones.Remove(inscripciones);
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
