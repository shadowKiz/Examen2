using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Exa.Data;
using Exa.Models;

namespace Exa.Controllers
{
    public class Tabla1Controller : Controller
    {
        private ExaContext db = new ExaContext();

        // GET: Tabla1
        public ActionResult Index()
        {
            return View(db.Tabla1.ToList());
        }

        // GET: Tabla1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabla1 tabla1 = db.Tabla1.Find(id);
            if (tabla1 == null)
            {
                return HttpNotFound();
            }
            return View(tabla1);
        }

        // GET: Tabla1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tabla1/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Nombre,Compania,Empleados")] Tabla1 tabla1)
        {
            if (ModelState.IsValid)
            {
                db.Tabla1.Add(tabla1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tabla1);
        }

        // GET: Tabla1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabla1 tabla1 = db.Tabla1.Find(id);
            if (tabla1 == null)
            {
                return HttpNotFound();
            }
            return View(tabla1);
        }

        // POST: Tabla1/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Nombre,Compania,Empleados")] Tabla1 tabla1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tabla1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tabla1);
        }

        // GET: Tabla1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tabla1 tabla1 = db.Tabla1.Find(id);
            if (tabla1 == null)
            {
                return HttpNotFound();
            }
            return View(tabla1);
        }

        // POST: Tabla1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tabla1 tabla1 = db.Tabla1.Find(id);
            db.Tabla1.Remove(tabla1);
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
