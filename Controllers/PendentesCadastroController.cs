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
    public class PendentesCadastroController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendentesCadastro
        public ActionResult Index()
        {
            List<PreCadastroUniverso> pcu = db.PreCadastroUniverso
                                            .Where(x=>x.AcervoInfo!="true").ToList();
            return View(pcu);
        }

        // GET: PendentesCadastro/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // GET: PendentesCadastro/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PendentesCadastro/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado")] PreCadastroUniverso preCadastroUniverso)
        {
            if (ModelState.IsValid)
            {
                db.PreCadastroUniverso.Add(preCadastroUniverso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(preCadastroUniverso);
        }

        // GET: PendentesCadastro/Edit/5
        [HttpGet]
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // POST: PendentesCadastro/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado")] PreCadastroUniverso preCadastroUniverso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preCadastroUniverso).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(preCadastroUniverso);
        }

        // GET: PendentesCadastro/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // POST: PendentesCadastro/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            db.PreCadastroUniverso.Remove(preCadastroUniverso);
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
