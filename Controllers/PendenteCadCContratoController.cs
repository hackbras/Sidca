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
    public class PendenteCadCContratoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendenteCadCContrato
        public ActionResult Index()
        {
            var cadContrato = db.CadContrato;//.Include(c => c.PreCadastroUniverso);
            return View(cadContrato.ToList());
        }

        // GET: PendenteCadCContrato/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadContrato cadContrato = db.CadContrato.Find(id);
            if (cadContrato == null)
            {
                return HttpNotFound();
            }
            return View(cadContrato);
        }

        // GET: PendenteCadCContrato/Create
        public ActionResult Create()
        {
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo");
            return View();
        }

        // POST: PendenteCadCContrato/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,NoParte,NuContrato")] CadContrato cadContrato)
        {
            if (ModelState.IsValid)
            {
                db.CadContrato.Add(cadContrato);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadContrato.Expediente);
            return View(cadContrato);
        }

        // GET: PendenteCadCContrato/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadContrato cadContrato = db.CadContrato.Find(id);
            if (cadContrato == null)
            {
                return HttpNotFound();
            }
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadContrato.Expediente);
            return View(cadContrato);
        }

        // POST: PendenteCadCContrato/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,NoParte,NuContrato")] CadContrato cadContrato)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadContrato).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Expediente = new SelectList(db.PreCadastroUniverso, "Expediente", "Processo", cadContrato.Expediente);
            return View(cadContrato);
        }

        // GET: PendenteCadCContrato/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadContrato cadContrato = db.CadContrato.Find(id);
            if (cadContrato == null)
            {
                return HttpNotFound();
            }
            return View(cadContrato);
        }

        // POST: PendenteCadCContrato/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadContrato cadContrato = db.CadContrato.Find(id);
            db.CadContrato.Remove(cadContrato);
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
