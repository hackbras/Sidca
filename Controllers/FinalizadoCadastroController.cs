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
    public class FinalizadoCadastroController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: FinalizadoCadastro
        public ActionResult Index()
        {
            return View(db.vw_cadastro_finalizado.ToList());
        }

        // GET: FinalizadoCadastro/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadastro_finalizado vw_cadastro_finalizado = db.vw_cadastro_finalizado.Find(id);
            if (vw_cadastro_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadastro_finalizado);
        }

        // GET: FinalizadoCadastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FinalizadoCadastro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,Processo,NuAdvogado,AreaJud,GrupoAssunto,DtEntrada,VlrCausa,DtCausa,NuVara,NuForo,DtFinalizado,Finalizado")] vw_cadastro_finalizado vw_cadastro_finalizado)
        {
            if (ModelState.IsValid)
            {
                db.vw_cadastro_finalizado.Add(vw_cadastro_finalizado);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(vw_cadastro_finalizado);
        }

        // GET: FinalizadoCadastro/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadastro_finalizado vw_cadastro_finalizado = db.vw_cadastro_finalizado.Find(id);
            if (vw_cadastro_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadastro_finalizado);
        }

        // POST: FinalizadoCadastro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Processo,NuAdvogado,AreaJud,GrupoAssunto,DtEntrada,VlrCausa,DtCausa,NuVara,NuForo,DtFinalizado,Finalizado")] vw_cadastro_finalizado vw_cadastro_finalizado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vw_cadastro_finalizado).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vw_cadastro_finalizado);
        }

        // GET: FinalizadoCadastro/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            vw_cadastro_finalizado vw_cadastro_finalizado = db.vw_cadastro_finalizado.Find(id);
            if (vw_cadastro_finalizado == null)
            {
                return HttpNotFound();
            }
            return View(vw_cadastro_finalizado);
        }

        // POST: FinalizadoCadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            vw_cadastro_finalizado vw_cadastro_finalizado = db.vw_cadastro_finalizado.Find(id);
            db.vw_cadastro_finalizado.Remove(vw_cadastro_finalizado);
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
