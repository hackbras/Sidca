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
    public class FinalizadoAcervoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: FinalizadoAcervo
        public ActionResult Index()
        {
            return View(db.vw_cadAdvogadoAcervo_finalizado.ToList());
        }

        // GET: FinalizadoAcervo/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado = db.vw_cadAdvogadoAcervo_finalizado.Find(id);
            if (vw_cadAdvogadoAcervo_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadAdvogadoAcervo_finalizado);
        }

        // GET: FinalizadoAcervo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinalizadoAcervo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,Processo,DtEntrada,NoParteJudicial,ExpVinculado,NuAdvogado,IdTerceirizacao,IdRelevante,AcervoInfo,DtAcervoInfo")] vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado)
        {
            if (ModelState.IsValid)
            {
                db.vw_cadAdvogadoAcervo_finalizado.Add(vw_cadAdvogadoAcervo_finalizado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_cadAdvogadoAcervo_finalizado);
        }

        // GET: FinalizadoAcervo/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado = db.vw_cadAdvogadoAcervo_finalizado.Find(id);
            if (vw_cadAdvogadoAcervo_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadAdvogadoAcervo_finalizado);
        }

        // POST: FinalizadoAcervo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Processo,DtEntrada,NoParteJudicial,ExpVinculado,NuAdvogado,IdTerceirizacao,IdRelevante,AcervoInfo,DtAcervoInfo")] vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_cadAdvogadoAcervo_finalizado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_cadAdvogadoAcervo_finalizado);
        }

        // GET: FinalizadoAcervo/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado = db.vw_cadAdvogadoAcervo_finalizado.Find(id);
            if (vw_cadAdvogadoAcervo_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadAdvogadoAcervo_finalizado);
        }

        // POST: FinalizadoAcervo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vw_cadAdvogadoAcervo_finalizado vw_cadAdvogadoAcervo_finalizado = db.vw_cadAdvogadoAcervo_finalizado.Find(id);
            db.vw_cadAdvogadoAcervo_finalizado.Remove(vw_cadAdvogadoAcervo_finalizado);
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
