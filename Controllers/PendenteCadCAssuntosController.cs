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
    public class PendenteCadCAssuntosController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendenteCadCAssuntos
        public ActionResult Index()
        {
            var cadAssunto = db.CadAssunto.Include(c => c.PreCadastroUniverso);
            return View(cadAssunto.ToList());
        }

        // GET: PendenteCadCAssuntos/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAssunto cadAssunto = db.CadAssunto.Find(id);
            if (cadAssunto == null)
            {
                return HttpNotFound();
            }
            return View(cadAssunto);
        }

        // GET: PendenteCadCAssuntos/Create
        public ActionResult Create()
        {
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo");
            return View();
        }

        // POST: PendenteCadCAssuntos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,Assunto")] CadAssunto cadAssunto)
        {
            if (ModelState.IsValid)
            {
                db.CadAssunto.Add(cadAssunto);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadAssunto.Expediente);
            return View(cadAssunto);
        }

        // GET: PendenteCadCAssuntos/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAssunto cadAssunto = db.CadAssunto.Find(id);
            if (cadAssunto == null)
            {
                return HttpNotFound();
            }
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadAssunto.Expediente);
            return View(cadAssunto);
        }

        // POST: PendenteCadCAssuntos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Assunto")] CadAssunto cadAssunto)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadAssunto).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadAssunto.Expediente);
            return View(cadAssunto);
        }

        // GET: PendenteCadCAssuntos/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadAssunto cadAssunto = db.CadAssunto.Find(id);
            if (cadAssunto == null)
            {
                return HttpNotFound();
            }
            return View(cadAssunto);
        }

        // POST: PendenteCadCAssuntos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadAssunto cadAssunto = db.CadAssunto.Find(id);
            db.CadAssunto.Remove(cadAssunto);
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
