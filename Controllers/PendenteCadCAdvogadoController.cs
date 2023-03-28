using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SidcaMrv2.Models;

namespace SidcaMrv2.Controllers
{
    public class PendenteCadCAdvogadoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendenteCadCAdvogado
        public ActionResult Index()
        {
            return View(db.CadAdvogadoContra.ToList());
        }

        // GET: PendenteCadCAdvogado/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAdvogadoContra cadAdvogadoContra = db.CadAdvogadoContra.Find(id);
            if (cadAdvogadoContra == null)
            {
                return HttpNotFound();
            }
            return View(cadAdvogadoContra);
        }

        // GET: PendenteCadCAdvogado/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PendenteCadCAdvogado/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,AdvogadoContra,NuOAB")] CadAdvogadoContra cadAdvogadoContra)
        {
            if (ModelState.IsValid)
            {
                db.CadAdvogadoContra.Add(cadAdvogadoContra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadAdvogadoContra);
        }

        // GET: PendenteCadCAdvogado/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAdvogadoContra cadAdvogadoContra = db.CadAdvogadoContra.Find(id);
            if (cadAdvogadoContra == null)
            {
                return HttpNotFound();
            }
            return View(cadAdvogadoContra);
        }

        // POST: PendenteCadCAdvogado/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,AdvogadoContra,NuOAB")] CadAdvogadoContra cadAdvogadoContra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadAdvogadoContra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadAdvogadoContra);
        }

        // GET: PendenteCadCAdvogado/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAdvogadoContra cadAdvogadoContra = db.CadAdvogadoContra.Find(id);
            if (cadAdvogadoContra == null)
            {
                return HttpNotFound();
            }
            return View(cadAdvogadoContra);
        }

        // POST: PendenteCadCAdvogado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadAdvogadoContra cadAdvogadoContra = db.CadAdvogadoContra.Find(id);
            db.CadAdvogadoContra.Remove(cadAdvogadoContra);
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
