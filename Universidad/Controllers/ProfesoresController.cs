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
    public class ProfesoresController : Controller
    {
        private UContext db = new UContext();

        // GET: Profesores
        public ActionResult Index()
        {
            var profesores = db.Profesores.Include(p => p.Barrio).Include(p => p.Ciudad);
            return View(profesores.ToList());
        }

        // GET: Profesores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // GET: Profesores/Create
        public ActionResult Create()
        {
            ViewBag.BarrioId = new SelectList(db.Barrios, "BarrioId", "Descripcion");
            ViewBag.CiudadId = new SelectList(db.Ciudads, "CiudadId", "Descripcion");
            return View();
        }

        // POST: Profesores/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProfesorId,FechaNac,SexoId,BarrioId,CiudadId,Direccion")] Profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.Profesores.Add(profesores);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.BarrioId = new SelectList(db.Barrios, "BarrioId", "Descripcion", profesores.BarrioId);
            ViewBag.CiudadId = new SelectList(db.Ciudads, "CiudadId", "Descripcion", profesores.CiudadId);
            return View(profesores);
        }

        // GET: Profesores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            ViewBag.BarrioId = new SelectList(db.Barrios, "BarrioId", "Descripcion", profesores.BarrioId);
            ViewBag.CiudadId = new SelectList(db.Ciudads, "CiudadId", "Descripcion", profesores.CiudadId);
            return View(profesores);
        }

        // POST: Profesores/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProfesorId,FechaNac,SexoId,BarrioId,CiudadId,Direccion")] Profesores profesores)
        {
            if (ModelState.IsValid)
            {
                db.Entry(profesores).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.BarrioId = new SelectList(db.Barrios, "BarrioId", "Descripcion", profesores.BarrioId);
            ViewBag.CiudadId = new SelectList(db.Ciudads, "CiudadId", "Descripcion", profesores.CiudadId);
            return View(profesores);
        }

        // GET: Profesores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Profesores profesores = db.Profesores.Find(id);
            if (profesores == null)
            {
                return HttpNotFound();
            }
            return View(profesores);
        }

        // POST: Profesores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Profesores profesores = db.Profesores.Find(id);
            db.Profesores.Remove(profesores);
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
