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
    public class DetMallaController : Controller
    {
        private UContext db = new UContext();

        // GET: DetMalla
        public ActionResult Index()
        {
            return View(db.DetMallas.ToList());
        }

        // GET: DetMalla/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetMalla detMalla = db.DetMallas.Find(id);
            if (detMalla == null)
            {
                return HttpNotFound();
            }
            return View(detMalla);
        }

        // GET: DetMalla/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DetMalla/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DetmallaId,MallaId,MateriaId")] DetMalla detMalla)
        {
            if (ModelState.IsValid)
            {
                db.DetMallas.Add(detMalla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(detMalla);
        }

        // GET: DetMalla/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetMalla detMalla = db.DetMallas.Find(id);
            if (detMalla == null)
            {
                return HttpNotFound();
            }
            return View(detMalla);
        }

        // POST: DetMalla/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DetmallaId,MallaId,MateriaId")] DetMalla detMalla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(detMalla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(detMalla);
        }

        // GET: DetMalla/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DetMalla detMalla = db.DetMallas.Find(id);
            if (detMalla == null)
            {
                return HttpNotFound();
            }
            return View(detMalla);
        }

        // POST: DetMalla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            DetMalla detMalla = db.DetMallas.Find(id);
            db.DetMallas.Remove(detMalla);
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
