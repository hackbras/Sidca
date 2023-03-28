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
    public class PendenteCadCadastramentoController : Controller
    {
        private DbContexto db = new DbContexto();

        // GET: PendenteCadCadastramento
        public ActionResult Index()
        {
            return View(db.PreCadastroUniverso.ToList());
        }
        [HttpPost]
        public ActionResult DdlAcao(string id, string result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.TpAcao = result;
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DdlComarca(string id, string result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.Comarca = result;
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DdlForo(string id, string result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.NuForo = result;
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult DdlAreaJud(string id, string result)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).Single(); ;
            preCadastroUniverso.AreaJud = result;
            db.SaveChanges();
            return Json(true, JsonRequestBehavior.AllowGet);
        }



        // GET: PendenteCadCadastramento/Details/5
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

        // GET: PendenteCadCadastramento/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PendenteCadCadastramento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado,Expediente_id")] PreCadastroUniverso preCadastroUniverso)
        {
            if (ModelState.IsValid)
            {
                db.PreCadastroUniverso.Add(preCadastroUniverso);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(preCadastroUniverso);
        }

        // GET: PendenteCadCadastramento/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Where(x => x.Expediente.ToString().Replace(".", "").Replace("/", "") == id).FirstOrDefault();//.Find(id);
            if (preCadastroUniverso == null)
            {
                return HttpNotFound();
            }
            ViewBag.comarcas = from cc in db.Codigo_Comarca
                               orderby cc.DE_COMARCA
                               select cc.DE_COMARCA;//.ToList();

            ViewBag.foros = from cf in db.Codigo_Foro
                            orderby cf.DE_FORO
                            select cf.DE_FORO;//.ToList();
            
            ViewBag.tiposAcao = from ca in db.Codigo_Acao
                                orderby ca.DE_ACAO
                                select ca.DE_ACAO;//.ToList();

            ViewBag.areasJud = from aj in db.vw_area
                              orderby aj.Area
                              select aj.Area;

            ViewBag.centrosCusto = from cc in db.Codigo_Unidade
                                  orderby cc.NO_UNIDADE
                                  select cc.NO_UNIDADE;

            ViewBag.unidsSubsidio = from cc in db.Codigo_Unidade
                                   orderby cc.NO_UNIDADE
                                   select cc.NO_UNIDADE;

            ViewBag.gridCentrosCusto = db.PlanPortalCentroCusto.SqlQuery("select * from PlanPortalCentroCusto WHERE Area='feitos'AND No_Grupo = 'A DEPURAR'").ToList();

            ViewBag.Expediente = preCadastroUniverso.Expediente;

            return View(preCadastroUniverso);
        }




        // POST: PendenteCadCadastramento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Expediente,Processo,NoParteJudicial,CondicaoParte,DtEntrada,NuAdvogado,AreaJud,GrupoAssunto,VlrCausa,DtCausa,NuVara,NuForo,Comarca,CentroCusto,UnidSubsidio,TpAcao,IdTerceirizacao,IdRelevante,ExpVinculado,DtAcervoInfo,AcervoInfo,DtFinalizado,Finalizado,Expediente_id")] PreCadastroUniverso preCadastroUniverso)
        {
            if (ModelState.IsValid)
            {
                db.Entry(preCadastroUniverso).State = EntityState.Modified;
                db.SaveChanges();
                //return RedirectToAction("Index");
            }
            return View(preCadastroUniverso);
        }

        // GET: PendenteCadCadastramento/Delete/5
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

        // POST: PendenteCadCadastramento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            PreCadastroUniverso preCadastroUniverso = db.PreCadastroUniverso.Find(id);
            db.PreCadastroUniverso.Remove(preCadastroUniverso);
            db.SaveChanges();
            return RedirectToAction("Index");
        }


        public ActionResult GetAssunto(string area)
        {
            List<string> assuntos = db.PlanPortalCentroCusto
                .Where(x => x.Area == area)
                .Select(m => m.No_Grupo)
                .ToList();

            return Json(assuntos.Distinct(), JsonRequestBehavior.AllowGet);
                
        }



        public ActionResult GetCentroCusto(string area, string assunto)
        {
            var query = $"select* from PlanPortalCentroCusto WHERE Area = '{area }'";


                if (assunto != "") {
                     query += $" AND No_Grupo = '{assunto}'";
                }

                
            var model = db.PlanPortalCentroCusto.SqlQuery(query).ToList();
            return PartialView("~/Views/PendenteCadCadastramento/_ListCentroCusto.cshtml", model);
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
