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
    public class PendentesAcervoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendentesAcervo
        public ActionResult Index()
        {
            var LA = from la in db.AdvogadoCaixa
                     orderby la.NoAdvogado         
                     select la.NoAdvogado;

            ViewBag.ListaAdvogados = LA.ToList();

            List<PreCadastroUniverso> pcu = db.PreCadastroUniverso
                                           .Where(x => x.AcervoInfo != "true").ToList();
            return View(pcu);
        }

        // GET: PendentesAcervo/Details/5
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

        // GET: PendentesAcervo/Create
        [HttpGet]
        //[ValidateAntiForgeryToken]
        public ActionResult Create(string id)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            CadConsultaRelevante ccr = new CadConsultaRelevante();
            

            //não localizou nada, mesmo procurando os dois registros já cadastrados
            CadConsultaRelevante Cad = db.CadConsultaRelevante.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).FirstOrDefault();//.Find();
            if (Cad==null)
            {
                ccr.Expediente = preCadastroUniverso.Expediente;
                ViewBag.Expediente = preCadastroUniverso.Expediente;

                return View(ccr);
            }
            else
               return View(Cad);
            
        }

        // POST: PendentesAcervo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CadConsultaRelevante cr)
        {
            CadConsultaRelevante Cad = db.CadConsultaRelevante.Where(x => x.Expediente == cr.Expediente).FirstOrDefault();//.Find();

            if (ModelState.IsValid)
            {
                if (Cad == null)                
                    db.CadConsultaRelevante.Add(cr);                
                else
                    db.Entry(cr).State = EntityState.Modified;                

                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cr);
        }

        // GET: PendentesAcervo/Edit/5
        public ActionResult Edit_processo_vinculado(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CadExpedienteVinculado cev = db.CadExpedienteVinculado.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            if (cev == null)
            {
                return HttpNotFound();
            }
            return View(cev);
        }

        public ActionResult Edit_processo_relevante(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single();//.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            return View(preCadastroUniverso);
        }

        // POST: PendentesAcervo/Edit/5
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

        // GET: PendentesAcervo/Delete/5
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

        // POST: PendentesAcervo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            db.PreCadastroUniverso.Remove(preCadastroUniverso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult AptoTerc(string id, bool result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.IdTerceirizacao = (result) ? "true" : "false";
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult AceConcl(string id, bool result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
           
            if (result)
            {
                preCadastroUniverso.AcervoInfo = "true" ;
                preCadastroUniverso.DtAcervoInfo = DateTime.Now.ToString("dd/MM/yyyy");
            }
            else
            {
                preCadastroUniverso.AcervoInfo = "false";
            }

            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DdlAdv(string id, string result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.NuAdvogado = result;
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
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
