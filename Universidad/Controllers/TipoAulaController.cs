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
    public class TipoAulaController : Controller
    {
        private UContext db = new UContext();

        // GET: TipoAula
        public ActionResult Index()
        {
            return View(db.TipoAulas.ToList());
        }

        // GET: TipoAula/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        // GET: TipoAula/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TipoAula/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TipoAulaId,Tipo,Capacidad,Wifi")] TipoAula tipoAula)
        {
            if (ModelState.IsValid)
            {
                db.TipoAulas.Add(tipoAula);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tipoAula);
        }

        // GET: TipoAula/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        // POST: TipoAula/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TipoAulaId,Tipo,Capacidad,Wifi")] TipoAula tipoAula)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tipoAula).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tipoAula);
        }

        // GET: TipoAula/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TipoAula tipoAula = db.TipoAulas.Find(id);
            if (tipoAula == null)
            {
                return HttpNotFound();
            }
            return View(tipoAula);
        }

        // POST: TipoAula/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            TipoAula tipoAula = db.TipoAulas.Find(id);
            db.TipoAulas.Remove(tipoAula);
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
