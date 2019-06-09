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
    public class MallaController : Controller
    {
        private UContext db = new UContext();

        // GET: Malla
        public ActionResult Index()
        {
            return View(db.Mallas.ToList());
        }

        // GET: Malla/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malla malla = db.Mallas.Find(id);
            if (malla == null)
            {
                return HttpNotFound();
            }
            return View(malla);
        }

        // GET: Malla/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Malla/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdMalla,NomMalla,InicioValidez,FinValidez")] Malla malla)
        {
            if (ModelState.IsValid)
            {
                db.Mallas.Add(malla);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(malla);
        }

        // GET: Malla/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malla malla = db.Mallas.Find(id);
            if (malla == null)
            {
                return HttpNotFound();
            }
            return View(malla);
        }

        // POST: Malla/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdMalla,NomMalla,InicioValidez,FinValidez")] Malla malla)
        {
            if (ModelState.IsValid)
            {
                db.Entry(malla).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(malla);
        }

        // GET: Malla/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Malla malla = db.Mallas.Find(id);
            if (malla == null)
            {
                return HttpNotFound();
            }
            return View(malla);
        }

        // POST: Malla/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Malla malla = db.Mallas.Find(id);
            db.Mallas.Remove(malla);
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
