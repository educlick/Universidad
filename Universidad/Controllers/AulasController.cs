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
    public class AulasController : Controller
    {
        private UContext db = new UContext();

        // GET: Aulas
        public ActionResult Index()
        {
            var aulas = db.Aulas.Include(a => a.TipoAula);
            return View(aulas.ToList());
        }

        // GET: Aulas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aulas aulas = db.Aulas.Find(id);
            if (aulas == null)
            {
                return HttpNotFound();
            }
            return View(aulas);
        }

        // GET: Aulas/Create
        public ActionResult Create()
        {
            ViewBag.TipoAulaId = new SelectList(db.TipoAulas, "TipoAulaId", "Tipo");
            return View();
        }

        // POST: Aulas/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AulaId,TipoAulaId")] Aulas aulas)
        {
            if (ModelState.IsValid)
            {
                db.Aulas.Add(aulas);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.TipoAulaId = new SelectList(db.TipoAulas, "TipoAulaId", "Tipo", aulas.TipoAulaId);
            return View(aulas);
        }

        // GET: Aulas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aulas aulas = db.Aulas.Find(id);
            if (aulas == null)
            {
                return HttpNotFound();
            }
            ViewBag.TipoAulaId = new SelectList(db.TipoAulas, "TipoAulaId", "Tipo", aulas.TipoAulaId);
            return View(aulas);
        }

        // POST: Aulas/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AulaId,TipoAulaId")] Aulas aulas)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aulas).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TipoAulaId = new SelectList(db.TipoAulas, "TipoAulaId", "Tipo", aulas.TipoAulaId);
            return View(aulas);
        }

        // GET: Aulas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aulas aulas = db.Aulas.Find(id);
            if (aulas == null)
            {
                return HttpNotFound();
            }
            return View(aulas);
        }

        // POST: Aulas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aulas aulas = db.Aulas.Find(id);
            db.Aulas.Remove(aulas);
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
