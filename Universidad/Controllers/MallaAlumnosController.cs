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
    public class MallaAlumnosController : Controller
    {
        private UContext db = new UContext();

        // GET: MallaAlumnos
        public ActionResult Index()
        {
            return View(db.MallaAlumnos.ToList());
        }

        // GET: MallaAlumnos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MallaAlumnos mallaAlumnos = db.MallaAlumnos.Find(id);
            if (mallaAlumnos == null)
            {
                return HttpNotFound();
            }
            return View(mallaAlumnos);
        }

        // GET: MallaAlumnos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MallaAlumnos/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MallaaluId,MallaId,AlumnoId,InicioValidez,FinValidez")] MallaAlumnos mallaAlumnos)
        {
            if (ModelState.IsValid)
            {
                db.MallaAlumnos.Add(mallaAlumnos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mallaAlumnos);
        }

        // GET: MallaAlumnos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MallaAlumnos mallaAlumnos = db.MallaAlumnos.Find(id);
            if (mallaAlumnos == null)
            {
                return HttpNotFound();
            }
            return View(mallaAlumnos);
        }

        // POST: MallaAlumnos/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MallaaluId,MallaId,AlumnoId,InicioValidez,FinValidez")] MallaAlumnos mallaAlumnos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(mallaAlumnos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mallaAlumnos);
        }

        // GET: MallaAlumnos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MallaAlumnos mallaAlumnos = db.MallaAlumnos.Find(id);
            if (mallaAlumnos == null)
            {
                return HttpNotFound();
            }
            return View(mallaAlumnos);
        }

        // POST: MallaAlumnos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            MallaAlumnos mallaAlumnos = db.MallaAlumnos.Find(id);
            db.MallaAlumnos.Remove(mallaAlumnos);
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
