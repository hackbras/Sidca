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
    public class PendenteCadCPartesController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendenteCadCPartes
        public ActionResult Index()
        {
            return View(db.CadParteJudicial.ToList());
        }

        // GET: PendenteCadCPartes/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadParteJudicial cadParteJudicial = db.CadParteJudicial.Find(id);
            if (cadParteJudicial == null)
            {
                return HttpNotFound();
            }
            return View(cadParteJudicial);
        }

        // GET: PendenteCadCPartes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PendenteCadCPartes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,NoParteJudicial,CpfCnpj,CondicaoParte,Matricula")] CadParteJudicial cadParteJudicial)
        {
            if (ModelState.IsValid)
            {
                db.CadParteJudicial.Add(cadParteJudicial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cadParteJudicial);
        }

        // GET: PendenteCadCPartes/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadParteJudicial cadParteJudicial = db.CadParteJudicial.Find(id);
            if (cadParteJudicial == null)
            {
                return HttpNotFound();
            }
            return View(cadParteJudicial);
        }

        // POST: PendenteCadCPartes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,NoParteJudicial,CpfCnpj,CondicaoParte,Matricula")] CadParteJudicial cadParteJudicial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cadParteJudicial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cadParteJudicial);
        }

        // GET: PendenteCadCPartes/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadParteJudicial cadParteJudicial = db.CadParteJudicial.Find(id);
            if (cadParteJudicial == null)
            {
                return HttpNotFound();
            }
            return View(cadParteJudicial);
        }

        // POST: PendenteCadCPartes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            CadParteJudicial cadParteJudicial = db.CadParteJudicial.Find(id);
            db.CadParteJudicial.Remove(cadParteJudicial);
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
