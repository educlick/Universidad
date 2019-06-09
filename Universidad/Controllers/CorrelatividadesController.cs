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
    public class CorrelatividadesController : Controller
    {
        private UContext db = new UContext();

        // GET: Correlatividades
        public ActionResult Index()
        {
            var correlatividades = db.Correlatividades.Include(c => c.DetMalla);
            return View(correlatividades.ToList());
        }

        // GET: Correlatividades/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Correlatividades correlatividades = db.Correlatividades.Find(id);
            if (correlatividades == null)
            {
                return HttpNotFound();
            }
            return View(correlatividades);
        }

        // GET: Correlatividades/Create
        public ActionResult Create()
        {
            ViewBag.DetmallaId = new SelectList(db.DetMallas, "DetmallaId", "DetmallaId");
            return View();
        }

        // POST: Correlatividades/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "CorredetId,DetmallaId,Orden_1,MateriaId")] Correlatividades correlatividades)
        {
            if (ModelState.IsValid)
            {
                db.Correlatividades.Add(correlatividades);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DetmallaId = new SelectList(db.DetMallas, "DetmallaId", "DetmallaId", correlatividades.DetmallaId);
            return View(correlatividades);
        }

        // GET: Correlatividades/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Correlatividades correlatividades = db.Correlatividades.Find(id);
            if (correlatividades == null)
            {
                return HttpNotFound();
            }
            ViewBag.DetmallaId = new SelectList(db.DetMallas, "DetmallaId", "DetmallaId", correlatividades.DetmallaId);
            return View(correlatividades);
        }

        // POST: Correlatividades/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CorredetId,DetmallaId,Orden_1,MateriaId")] Correlatividades correlatividades)
        {
            if (ModelState.IsValid)
            {
                db.Entry(correlatividades).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DetmallaId = new SelectList(db.DetMallas, "DetmallaId", "DetmallaId", correlatividades.DetmallaId);
            return View(correlatividades);
        }

        // GET: Correlatividades/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Correlatividades correlatividades = db.Correlatividades.Find(id);
            if (correlatividades == null)
            {
                return HttpNotFound();
            }
            return View(correlatividades);
        }

        // POST: Correlatividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Correlatividades correlatividades = db.Correlatividades.Find(id);
            db.Correlatividades.Remove(correlatividades);
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
